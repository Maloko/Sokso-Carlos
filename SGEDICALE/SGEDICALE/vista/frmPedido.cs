using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SGEDICALE.controlador;
using SGEDICALE.clases;
using Microsoft.Win32;
using Microsoft.Office.Interop.Excel;
using System.Text.RegularExpressions;
using System.Data;
using System.IO;
using System.Threading;
using System.Globalization;

namespace SGEDICALE.vista
{
    public partial class frmPedido : DevComponents.DotNetBar.Office2007Form
    {
        int cantidad = 0;

        public frmPedido()
        {
            InitializeComponent();
        }

        private void frmPedido_Load(object sender, EventArgs e)
        {
            //Thread.CurrentThread.CurrentCulture = new CultureInfo("es-PE");
        }

        private void btnRuta_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            List<DataGridViewRow> temp = new List<DataGridViewRow>();
            try
            {

                string nombrearchivo = "";
                dgvPedido.DataSource = null;
                openFileDialog1.Filter = "Excel Files (*.xls;*.xlsx)|*.xls;*.xlsx";
                openFileDialog1.Title = "Seleccione el archivo de Excel";
                openFileDialog1.FileName = String.Empty;

                int contpedido = 0;
                string dni = "";
                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    txtRuta.Text = openFileDialog1.FileName;
                    nombrearchivo = Path.GetFileNameWithoutExtension(openFileDialog1.FileName);


                    if (txtRuta.Text == "")
                    {
                        MessageBox.Show("Escoja la ruta del archivo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.Cursor = Cursors.Default;
                        return;
                    }

                    dgvPedido.DataSource = CPedido.cargarGrilla(txtRuta.Text, nombrearchivo);
                    listBox1.Items.Clear();

                    //ANTIGUO GUARDADO
                    foreach (DataGridViewRow row in dgvPedido.Rows)
                    {

                        if (row.Cells[0].Value.ToString().Trim().ToLower() == "item")
                        {
                            contpedido = contpedido + 1;
                        }

                        if (checkBox1.Checked == false)
                        {
                            if (row.Cells[8].Value.ToString().Trim().ToLower() == "total:")
                            {

                                if (row.Cells[9].Value.ToString().Trim() == "0.00")
                                    contpedido = contpedido - 1;
                            }
                        }
                    }

                    lblnumero.Text = "N° Pedidos: ";
                    lblnumero.Text = lblnumero.Text + " " + contpedido;


                    dgvPedido.Refresh();
                }
                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Cursor = Cursors.Default;
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            try
            {

                cantidad = 0;
                List<DataGridViewRow> temp = new List<DataGridViewRow>();

                if (dgvPedido.Rows.Count == 0)
                {
                    this.Cursor = Cursors.Default;
                    return;
                }

                if (checkBox1.Checked == true)
                {
                    LecturaOfertas();
                }
                else
                {
                    LecturaNormal();
                }

                this.checkBox1.Checked = false;
                this.Cursor = Cursors.Default;
                MessageBox.Show(cantidad + " pedidos guardados.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Cursor = Cursors.Default;
            }

            this.Cursor = Cursors.Default;

        }

        public void GuardarPedido()
        {
            bool rpta = false;
            int posicion1 = 0;
            int posicion2 = 0;
            int total = 0;
            string cadena = "";
            string promotor = "";
            Pedido pedido = null;
            string numeropedido = "";
            DetallePedido detpedido = null;
            string[] separados;
            int j = 0;
            int columna = 0;
            string color = "";
            List<DataGridViewRow> temp = new List<DataGridViewRow>();
            string dni = "";
            int contpedido = 0;
            int count = 1;
            try
            {
                for (int i = 0; i < dgvPedido.Rows.Count; i++)
                {
                    if (dgvPedido.Rows[i].Cells[0].Value.ToString().Trim().ToLower() != "dni" && dgvPedido.Rows[i].Cells[0].Value.ToString() != "")
                    {

                        promotor = dgvPedido.Rows[i].Cells[1].Value.ToString().Trim().ToUpper();

                        if (promotor != "")
                        {
                            dni = dgvPedido.Rows[i].Cells[0].Value.ToString();

                            if (i != (dgvPedido.Rows.Count - 1))
                            {
                                if (dni != dgvPedido.Rows[i + 1].Cells[0].Value.ToString() && count <= 1)
                                {
                                    pedido = new Pedido();
                                    pedido.Promotor = promotor;
                                    pedido.Numeropedido = dgvPedido.Rows[i].Cells[2].Value.ToString().Trim();
                                    string marlon = dgvPedido.Rows[i].Cells[7].Value.ToString().Substring(0, 10).Trim();
                                    pedido.Fechapedido = Convert.ToDateTime(dgvPedido.Rows[i].Cells[7].Value.ToString().Substring(0, 10).Trim());
                                    pedido.Fechaenvio = DateTime.Now;
                                    pedido.Codusuario = Session.CodUsuario;

                                    pedido.Subtotal = Convert.ToDecimal(dgvPedido.Rows[i].Cells[14].Value.ToString().Trim());
                                    pedido.Igv = Convert.ToDecimal(dgvPedido.Rows[i].Cells[14].Value.ToString().Trim());
                                    pedido.Total = Convert.ToDecimal(dgvPedido.Rows[i].Cells[14].Value.ToString().Trim());


                                    color = dgvPedido.Rows[i].Cells[9].Value.ToString().Trim();

                                    detpedido = new DetallePedido();

                                    detpedido.Producto = dgvPedido.Rows[i].Cells[6].Value.ToString().Trim();
                                    detpedido.Producto = detpedido.Producto + " - " + color;
                                    detpedido.Catalogo = dgvPedido.Rows[i].Cells[4].Value.ToString().Trim();

                                    string valor = dgvPedido.Rows[i].Cells[5].Value.ToString();
                                    detpedido.Talla = dgvPedido.Rows[i].Cells[8].Value.ToString().Trim();
                                    detpedido.Cantidad = Convert.ToInt32(dgvPedido.Rows[i].Cells[10].Value.ToString().Trim());
                                    detpedido.Precio = Convert.ToDecimal(dgvPedido.Rows[i].Cells[14].Value.ToString().Trim());
                                    detpedido.Preciost = Convert.ToDecimal(dgvPedido.Rows[i].Cells[14].Value.ToString().Trim());

                                    detpedido.Codusuario = Session.CodUsuario;

                                    pedido.ListaDetallePedido.Add(detpedido);

                                    //insertar pedido con un solo detalle

                                    if (pedido.Total > 0)
                                    {
                                        rpta = CPedido.insertar(pedido);

                                        if (rpta == true)
                                        {
                                            cantidad = cantidad + 1;
                                        }
                                        else
                                        {
                                            listBox1.Items.Add(pedido.Promotor + "  " + detpedido.Producto + " TALLA: " + detpedido.Talla + "\n");
                                        }
                                    }
                                    count = 1;
                                }
                                else
                                {

                                    if (count == 1)
                                    {
                                        pedido = new Pedido();
                                        pedido.Promotor = promotor;
                                        pedido.Numeropedido = dgvPedido.Rows[i].Cells[2].Value.ToString().Trim();
                                        pedido.Fechapedido = Convert.ToDateTime(dgvPedido.Rows[i].Cells[7].Value.ToString().Substring(0, 10).Trim());
                                        pedido.Fechaenvio = DateTime.Now;
                                        pedido.Codusuario = Session.CodUsuario;

                                        pedido.Subtotal = Convert.ToDecimal(dgvPedido.Rows[i].Cells[14].Value.ToString().Trim());
                                        pedido.Igv = Convert.ToDecimal(dgvPedido.Rows[i].Cells[14].Value.ToString().Trim());
                                        pedido.Total = Convert.ToDecimal(dgvPedido.Rows[i].Cells[14].Value.ToString().Trim());


                                        color = dgvPedido.Rows[i].Cells[9].Value.ToString().Trim();

                                        detpedido = new DetallePedido();

                                        detpedido.Producto = dgvPedido.Rows[i].Cells[6].Value.ToString().Trim();
                                        detpedido.Producto = detpedido.Producto + " - " + color;
                                        detpedido.Catalogo = dgvPedido.Rows[i].Cells[4].Value.ToString().Trim();

                                        string valor = dgvPedido.Rows[i].Cells[5].Value.ToString();
                                        detpedido.Talla = dgvPedido.Rows[i].Cells[8].Value.ToString().Trim();
                                        detpedido.Cantidad = Convert.ToInt32(dgvPedido.Rows[i].Cells[10].Value.ToString().Trim());
                                        detpedido.Precio = Convert.ToDecimal(dgvPedido.Rows[i].Cells[14].Value.ToString().Trim());
                                        detpedido.Preciost = Convert.ToDecimal(dgvPedido.Rows[i].Cells[14].Value.ToString().Trim());

                                        detpedido.Codusuario = Session.CodUsuario;

                                        pedido.ListaDetallePedido.Add(detpedido);

                                        count = count + 1;
                                    }
                                    else
                                    {
                                        color = dgvPedido.Rows[i].Cells[9].Value.ToString().Trim();

                                        detpedido = new DetallePedido();

                                        detpedido.Producto = dgvPedido.Rows[i].Cells[6].Value.ToString().Trim();
                                        detpedido.Producto = detpedido.Producto + " - " + color;
                                        detpedido.Catalogo = dgvPedido.Rows[i].Cells[4].Value.ToString().Trim();

                                        string valor = dgvPedido.Rows[i].Cells[5].Value.ToString();
                                        detpedido.Talla = dgvPedido.Rows[i].Cells[8].Value.ToString().Trim();
                                        detpedido.Cantidad = Convert.ToInt32(dgvPedido.Rows[i].Cells[10].Value.ToString().Trim());
                                        detpedido.Precio = Convert.ToDecimal(dgvPedido.Rows[i].Cells[14].Value.ToString().Trim());
                                        detpedido.Preciost = Convert.ToDecimal(dgvPedido.Rows[i].Cells[14].Value.ToString().Trim());

                                        detpedido.Codusuario = Session.CodUsuario;

                                        pedido.ListaDetallePedido.Add(detpedido);

                                        count = count + 1;
                                    }

                                    dni = dgvPedido.Rows[i].Cells[0].Value.ToString();

                                    if (i != (dgvPedido.Rows.Count - 1))
                                    {
                                        if (dni != dgvPedido.Rows[i + 1].Cells[0].Value.ToString())
                                        {
                                            //insertar pedido con un solo detalle
                                            if (pedido.Total > 0)
                                            {
                                                rpta = CPedido.insertar(pedido);

                                                if (rpta == true)
                                                {
                                                    cantidad = cantidad + 1;
                                                }
                                                else
                                                {
                                                    listBox1.Items.Add(pedido.Promotor + "  " + detpedido.Producto + " TALLA: " + detpedido.Talla + "\n");
                                                }

                                                count = 1;
                                            }
                                        }
                                    }
                                }

                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " " + pedido.Promotor, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Cursor = Cursors.Default;
            }

        }


        public void LecturaOfertas()
        {
            bool rpta = false;
            int posicion1 = 0;
            int posicion2 = 0;
            int total = 0;
            string cadena = "";
            string promotor = "";
            Pedido pedido = null;
            string numeropedido = "";
            DetallePedido detpedido = null;
            string[] separados;
            int j = 0;
            int columna = 0;

            List<DataGridViewRow> temp = new List<DataGridViewRow>();


            try
            {
                for (int i = 0; i < dgvPedido.Rows.Count; i++)
                {

                    promotor = dgvPedido.Rows[i].Cells[0].Value.ToString().Trim();

                    if (i >= 7)
                    {
                        promotor = dgvPedido.Rows[i].Cells[0].Value.ToString().Trim();
                        if (promotor.Contains(" ("))
                        {
                            posicion1 = promotor.IndexOf("(");
                            posicion2 = promotor.IndexOf(")");
                            total = (posicion2 - posicion1) + 2;
                            cadena = promotor.Substring((posicion1 - 1), total);

                            promotor = promotor.Replace(cadena, "");

                        }

                        if (promotor != "")
                        {

                            pedido = new Pedido();
                            pedido.Promotor = promotor;
                            //pedido.Numerodocumento = Convert.ToInt32(dni);
                            pedido.Numerodocumento = 0;

                            if (numeropedido == "")
                            {
                                separados = dgvPedido.Rows[0].Cells[0].Value.ToString().Trim().Split(" ".ToCharArray());

                                int tamaño = separados.Length;
                                numeropedido = separados[tamaño - 1].ToString();
                                numeropedido = numeropedido.Replace("N°: ", "");
                            }

                            pedido.Numeropedido = numeropedido;

                            /*

                            if (numeropedido == "")
                            {
                                separados = dgvPedido.Rows[0].Cells[0].Value.ToString().Trim().Split(" ".ToCharArray());

                                int tamaño = separados.Length;
                                numeropedido = separados[tamaño - 1].ToString();
                                numeropedido = numeropedido.Replace("N°: ", "");
                            }
                            */


                            pedido.Fechapedido = Convert.ToDateTime(dgvPedido.Rows[0].Cells[3].Value);
                            pedido.Fechaenvio = DateTime.Now;

                            pedido.Codusuario = Session.CodUsuario;

                            i = i + 3;

                            detpedido = new DetallePedido();

                            detpedido.Producto = dgvPedido.Rows[i].Cells[1].Value.ToString().Trim();
                            detpedido.Producto = Regex.Replace(detpedido.Producto, @"\s+", " ");

                            detpedido.Catalogo = dgvPedido.Rows[i].Cells[2].Value.ToString().Trim();

                            string valor = dgvPedido.Rows[i].Cells[3].Value.ToString();
                            detpedido.Talla = dgvPedido.Rows[i].Cells[3].Value.ToString().Trim();
                            detpedido.Cantidad = Convert.ToInt32(dgvPedido.Rows[i].Cells[6].Value.ToString().Trim());

                            detpedido.Precio = Convert.ToDecimal(dgvPedido.Rows[i].Cells[7].Value.ToString().Trim().Replace("S/", ""));
                            detpedido.Preciost = Convert.ToDecimal(dgvPedido.Rows[i].Cells[8].Value.ToString().Trim().Replace("S/", ""));

                            detpedido.Codusuario = Session.CodUsuario;

                            if (dgvPedido.Rows[i + 1].Cells[2].Value.ToString() == "")
                            {

                                i = i + 3;

                                pedido.Subtotal = Convert.ToDecimal(dgvPedido.Rows[i].Cells[8].Value.ToString().Trim().Replace("S/", ""));

                                i = i + 1;
                                pedido.Igv = Convert.ToDecimal(dgvPedido.Rows[i].Cells[8].Value.ToString().Trim().Replace("S/", ""));
                                i = i + 1;
                                pedido.Total = Convert.ToDecimal(dgvPedido.Rows[i].Cells[8].Value.ToString().Trim().Replace("S/", ""));

                                if (i == 18)
                                {
                                    i = i + 1;
                                }

                                pedido.ListaDetallePedido.Add(detpedido);

                                //insertar pedido con un solo detalle

                                if (pedido.Total > 0)
                                {

                                    rpta = CPedido.insertar(pedido);

                                    if (rpta == true)
                                    {
                                        cantidad = cantidad + 1;
                                    }
                                    else
                                    {
                                        listBox1.Items.Add(pedido.Promotor + "  " + detpedido.Producto + " TALLA: " + detpedido.Talla + "\n");
                                    }
                                }

                            }
                            else
                            {
                                i = i + 1;
                                pedido.ListaDetallePedido.Add(detpedido);

                                for (j = 0; j < dgvPedido.Rows.Count; j++)
                                {

                                    if (dgvPedido.Rows[i].Cells[2].Value.ToString() != "")
                                    {

                                        detpedido = new DetallePedido();

                                        detpedido.Producto = dgvPedido.Rows[i].Cells[1].Value.ToString().Trim();
                                        detpedido.Producto = Regex.Replace(detpedido.Producto, @"\s+", " ");
                                        detpedido.Catalogo = dgvPedido.Rows[i].Cells[2].Value.ToString().Trim();
                                        detpedido.Talla = dgvPedido.Rows[i].Cells[3].Value.ToString().Trim();
                                        detpedido.Cantidad = Convert.ToInt32(dgvPedido.Rows[i].Cells[6].Value.ToString().Trim());

                                        detpedido.Precio = Convert.ToDecimal(dgvPedido.Rows[i].Cells[7].Value.ToString().Trim().Replace("S/", ""));
                                        detpedido.Preciost = Convert.ToDecimal(dgvPedido.Rows[i].Cells[8].Value.ToString().Trim().Replace("S/", ""));

                                        detpedido.Codusuario = Session.CodUsuario;

                                        pedido.ListaDetallePedido.Add(detpedido);
                                        j++;
                                        i = i + 1;

                                    }
                                    else
                                    {
                                        break;
                                    }
                                }

                                i = i + 2;


                                pedido.Subtotal = Convert.ToDecimal(dgvPedido.Rows[i].Cells[8].Value.ToString().Trim().Replace("S/", ""));
                                i = i + 1;
                                pedido.Igv = Convert.ToDecimal(dgvPedido.Rows[i].Cells[8].Value.ToString().Trim().Replace("S/", ""));
                                i = i + 1;
                                pedido.Total = Convert.ToDecimal(dgvPedido.Rows[i].Cells[8].Value.ToString().Trim().Replace("S/", ""));


                                if (pedido.Total > 0)
                                {
                                    rpta = CPedido.insertar(pedido);

                                    if (rpta == true)
                                    {
                                        cantidad = cantidad + 1;

                                    }
                                    else
                                    {
                                        listBox1.Items.Add(pedido.Promotor + "  " + detpedido.Producto + " TALLA: " + detpedido.Talla + "\n");
                                    }
                                }
                            }
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " " + pedido.Promotor, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Cursor = Cursors.Default;
            }

        }

        public void LecturaNormal()
        {
            bool rpta = false;
            int posicion1 = 0;
            int posicion2 = 0;
            int total = 0;
            string cadena = "";
            string promotor = "";
            Pedido pedido = null;
            string numeropedido = "";
            DetallePedido detpedido = null;
            string[] separados;
            int j = 0;
            int k = 0;
            int columna = 0;

            List<DataGridViewRow> temp = new List<DataGridViewRow>();

            try
            {

                for (int i = 0; i < dgvPedido.Rows.Count; i++)
                {

                    promotor = dgvPedido.Rows[i].Cells[0].Value.ToString().Trim();

                    if (i >= 3)
                    {
                        promotor = dgvPedido.Rows[i].Cells[0].Value.ToString().Trim();
                        if (promotor.Contains(" ("))
                        {
                            posicion1 = promotor.IndexOf("-");
                            posicion2 = promotor.IndexOf(")");
                            total = (posicion2 - posicion1) + 2;
                            cadena = promotor.Substring((posicion1 - 1), total);

                            promotor = promotor.Replace(cadena, "");
                            promotor = Regex.Replace(promotor, @"\s+", " ");

                        }

                        if (promotor != "")
                        {
                            pedido = new Pedido();
                            pedido.Promotor = promotor;
                            pedido.Numerodocumento = 0;

                            pedido.Numeropedido = dgvPedido.Rows[0].Cells[1].Value.ToString().Trim();

                            pedido.Fechapedido = Convert.ToDateTime(dgvPedido.Rows[0].Cells[3].Value);
                            pedido.Fechaenvio = DateTime.Now;

                            pedido.Codusuario = Session.CodUsuario;

                            i = i + 2;

                            detpedido = new DetallePedido();

                            detpedido.Producto = dgvPedido.Rows[i].Cells[2].Value.ToString().Trim();
                            detpedido.Producto = Regex.Replace(detpedido.Producto, @"\s+", " ");

                            detpedido.Catalogo = dgvPedido.Rows[i].Cells[3].Value.ToString().Trim();

                            string valor = dgvPedido.Rows[i].Cells[4].Value.ToString();
                            detpedido.Talla = dgvPedido.Rows[i].Cells[4].Value.ToString().Trim();
                            detpedido.Cantidad = Convert.ToInt32(dgvPedido.Rows[i].Cells[7].Value.ToString().Trim());
                            //detpedido.Precio = Convert.ToDecimal(dgvPedido.Rows[i].Cells[9].Value.ToString().Replace("S/. ", ""));
                            //detpedido.Preciost = Convert.ToDecimal(dgvPedido.Rows[i].Cells[10].Value.ToString().Replace("S/. ", ""));

                            detpedido.Precio = Convert.ToDecimal(dgvPedido.Rows[i].Cells[8].Value.ToString().Trim().Replace("S/", ""));
                            detpedido.Preciost = Convert.ToDecimal(dgvPedido.Rows[i].Cells[9].Value.ToString().Trim().Replace("S/", ""));

                            detpedido.Codusuario = Session.CodUsuario;

                            if (dgvPedido.Rows[i + 1].Cells[2].Value.ToString() == "")
                            {

                                i = i + 3;

                                //pedido.Subtotal = Convert.ToDecimal(dgvPedido.Rows[i].Cells[10].Value.ToString().Replace("S/. ", ""));
                                pedido.Subtotal = Convert.ToDecimal(dgvPedido.Rows[i].Cells[9].Value.ToString().Trim().Replace("S/", ""));
                                i = i + 1;
                                //pedido.Igv = Convert.ToDecimal(dgvPedido.Rows[i].Cells[10].Value.ToString().Replace("S/. ", ""));
                                pedido.Igv = Convert.ToDecimal(dgvPedido.Rows[i].Cells[9].Value.ToString().Trim().Replace("S/", ""));
                                i = i + 1;
                                //pedido.Total = Convert.ToDecimal(dgvPedido.Rows[i].Cells[10].Value.ToString().Replace("S/. ", ""));
                                pedido.Total = Convert.ToDecimal(dgvPedido.Rows[i].Cells[9].Value.ToString().Trim().Replace("S/", ""));

                                pedido.ListaDetallePedido.Add(detpedido);

                                //insertar pedido con un solo detalle

                                if (pedido.Total > 0)
                                {

                                    rpta = CPedido.insertar(pedido);

                                    if (rpta == true)
                                    {
                                        cantidad = cantidad + 1;
                                    }
                                    else
                                    {
                                        listBox1.Items.Add(pedido.Promotor + "  " + detpedido.Producto + " TALLA: " + detpedido.Talla + "\n");
                                    }
                                }

                            }
                            else
                            {
                                i = i + 1;
                                pedido.ListaDetallePedido.Add(detpedido);

                                for (j = 0; j < dgvPedido.Rows.Count; j++)
                                {

                                    if (dgvPedido.Rows[i].Cells[2].Value.ToString() != "")
                                    {

                                        detpedido = new DetallePedido();

                                        detpedido.Producto = dgvPedido.Rows[i].Cells[2].Value.ToString().Trim();
                                        detpedido.Producto = Regex.Replace(detpedido.Producto, @"\s+", " ");
                                        detpedido.Catalogo = dgvPedido.Rows[i].Cells[3].Value.ToString().Trim();
                                        detpedido.Talla = dgvPedido.Rows[i].Cells[4].Value.ToString().Trim();
                                        detpedido.Cantidad = Convert.ToInt32(dgvPedido.Rows[i].Cells[7].Value.ToString().Trim());
                                        //detpedido.Precio = Convert.ToDecimal(dgvPedido.Rows[i].Cells[9].Value.ToString().Replace("S/. ", ""));
                                        //detpedido.Preciost = Convert.ToDecimal(dgvPedido.Rows[i].Cells[10].Value.ToString().Replace("S/. ", ""));

                                        detpedido.Precio = Convert.ToDecimal(dgvPedido.Rows[i].Cells[8].Value.ToString().Trim().Replace("S/", ""));
                                        detpedido.Preciost = Convert.ToDecimal(dgvPedido.Rows[i].Cells[9].Value.ToString().Trim().Replace("S/", ""));

                                        detpedido.Codusuario = Session.CodUsuario;

                                        pedido.ListaDetallePedido.Add(detpedido);
                                        j++;
                                        i = i + 1;

                                    }
                                    else
                                    {
                                        break;
                                    }
                                }

                                i = i + 2;

                                //pedido.Subtotal = Convert.ToDecimal(dgvPedido.Rows[i].Cells[10].Value.ToString().Replace("S/. ", ""));
                                pedido.Subtotal = Convert.ToDecimal(dgvPedido.Rows[i].Cells[9].Value.ToString().Trim().Replace("S/", ""));
                                i = i + 1;
                                //pedido.Igv = Convert.ToDecimal(dgvPedido.Rows[i].Cells[10].Value.ToString().Replace("S/. ", ""));
                                pedido.Igv = Convert.ToDecimal(dgvPedido.Rows[i].Cells[9].Value.ToString().Trim().Replace("S/", ""));
                                i = i + 1;
                                //pedido.Total = Convert.ToDecimal(dgvPedido.Rows[i].Cells[10].Value.ToString().Replace("S/. ", ""));
                                pedido.Total = Convert.ToDecimal(dgvPedido.Rows[i].Cells[9].Value.ToString().Trim().Replace("S/", ""));


                                if (pedido.Total > 0)
                                {
                                    rpta = CPedido.insertar(pedido);

                                    if (rpta == true)
                                    {
                                        cantidad = cantidad + 1;

                                    }
                                    else
                                    {
                                        listBox1.Items.Add(pedido.Promotor + "  " + detpedido.Producto + " TALLA: " + detpedido.Talla + "\n");
                                    }
                                }
                            }
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " " + pedido.Promotor, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Cursor = Cursors.Default;
            }
        }


        /*
         //ANTIGUO SISTEMA
              public void LecturaNormal()
        {
            bool rpta = false;
            int posicion1 = 0;
            int posicion2 = 0;
            int total = 0;
            string cadena = "";
            string promotor = "";
            Pedido pedido = null;
            string numeropedido = "";
            DetallePedido detpedido = null;
            string[] separados;
            int j = 0;
            int columna = 0;

            List<DataGridViewRow> temp = new List<DataGridViewRow>();

            try
            {



                for (int i = 0; i < dgvPedido.Rows.Count; i++)
                {

                    promotor = dgvPedido.Rows[i].Cells[0].Value.ToString().Trim();

                    if (i >= 7)
                    {
                        promotor = dgvPedido.Rows[i].Cells[0].Value.ToString().Trim();
                        if (promotor.Contains(" ("))
                        {
                            posicion1 = promotor.IndexOf("(");
                            posicion2 = promotor.IndexOf(")");
                            total = (posicion2 - posicion1) + 2;
                            cadena = promotor.Substring((posicion1 - 1), total);

                            promotor = promotor.Replace(cadena, "");

                        }

                        if (promotor != "")
                        {
                            pedido = new Pedido();
                            pedido.Promotor = promotor;
                            //pedido.Numerodocumento = Convert.ToInt32(dni);
                            pedido.Numerodocumento = 0;

                            if (numeropedido == "")
                            {
                                separados = dgvPedido.Rows[0].Cells[0].Value.ToString().Trim().Split(" ".ToCharArray());

                                int tamaño = separados.Length;
                                numeropedido = separados[tamaño - 1].ToString();
                                numeropedido = numeropedido.Replace("N°: ", "");
                            }

                            pedido.Numeropedido = numeropedido;

                            pedido.Fechapedido = Convert.ToDateTime(dgvPedido.Rows[0].Cells[3].Value);
                            pedido.Fechaenvio = DateTime.Now;

                            pedido.Codusuario = Session.CodUsuario;

                            i = i + 3;

                            detpedido = new DetallePedido();

                            detpedido.Producto = dgvPedido.Rows[i].Cells[2].Value.ToString().Trim();
                            detpedido.Producto = Regex.Replace(detpedido.Producto, @"\s+", " ");

                            detpedido.Catalogo = dgvPedido.Rows[i].Cells[3].Value.ToString().Trim();

                            string valor = dgvPedido.Rows[i].Cells[5].Value.ToString();
                            detpedido.Talla = dgvPedido.Rows[i].Cells[5].Value.ToString().Trim();
                            detpedido.Cantidad = Convert.ToInt32(dgvPedido.Rows[i].Cells[8].Value.ToString().Trim());
                            //detpedido.Precio = Convert.ToDecimal(dgvPedido.Rows[i].Cells[9].Value.ToString().Trim().Replace("S/ ", ""));
                            //detpedido.Preciost = Convert.ToDecimal(dgvPedido.Rows[i].Cells[10].Value.ToString().Trim().Replace("S/ ", ""));

                            detpedido.Precio = Convert.ToDecimal(dgvPedido.Rows[i].Cells[9].Value.ToString().Trim().Replace("S/", ""));
                            detpedido.Preciost = Convert.ToDecimal(dgvPedido.Rows[i].Cells[10].Value.ToString().Trim().Replace("S/", ""));

                            detpedido.Codusuario = Session.CodUsuario;

                            if (dgvPedido.Rows[i + 1].Cells[2].Value.ToString() == "")
                            {

                                i = i + 3;

                                //pedido.Subtotal = Convert.ToDecimal(dgvPedido.Rows[i].Cells[10].Value.ToString().Trim().Replace("S/ ", ""));
                                pedido.Subtotal = Convert.ToDecimal(dgvPedido.Rows[i].Cells[10].Value.ToString().Trim().Replace("S/", ""));

                                i = i + 1;
                                //pedido.Igv = Convert.ToDecimal(dgvPedido.Rows[i].Cells[10].Value.ToString().Trim().Replace("S/ ", ""));
                                pedido.Igv = Convert.ToDecimal(dgvPedido.Rows[i].Cells[10].Value.ToString().Trim().Replace("S/", ""));
                                i = i + 1;
                                //pedido.Total = Convert.ToDecimal(dgvPedido.Rows[i].Cells[10].Value.ToString().Trim().Replace("S/ ", ""));
                                pedido.Total = Convert.ToDecimal(dgvPedido.Rows[i].Cells[10].Value.ToString().Trim().Replace("S/", ""));

                                if (i == 18)
                                {
                                    i = i + 1;
                                }

                                pedido.ListaDetallePedido.Add(detpedido);

                                //insertar pedido con un solo detalle

                                if (pedido.Total > 0)
                                {

                                    rpta = CPedido.insertar(pedido);

                                    if (rpta == true)
                                    {
                                        cantidad = cantidad + 1;
                                    }
                                    else
                                    {
                                        listBox1.Items.Add(pedido.Promotor + "  " + detpedido.Producto + " TALLA: " + detpedido.Talla + "\n");
                                    }
                                }

                            }
                            else
                            {
                                i = i + 1;
                                pedido.ListaDetallePedido.Add(detpedido);

                                for (j = 0; j < dgvPedido.Rows.Count; j++)
                                {

                                    if (dgvPedido.Rows[i].Cells[2].Value.ToString() != "")
                                    {

                                        detpedido = new DetallePedido();

                                        detpedido.Producto = dgvPedido.Rows[i].Cells[2].Value.ToString().Trim();
                                        detpedido.Producto = Regex.Replace(detpedido.Producto, @"\s+", " ");
                                        detpedido.Catalogo = dgvPedido.Rows[i].Cells[3].Value.ToString().Trim();
                                        detpedido.Talla = dgvPedido.Rows[i].Cells[5].Value.ToString().Trim();
                                        detpedido.Cantidad = Convert.ToInt32(dgvPedido.Rows[i].Cells[8].Value.ToString().Trim());

                                        detpedido.Precio = Convert.ToDecimal(dgvPedido.Rows[i].Cells[9].Value.ToString().Trim().Replace("S/", ""));
                                        detpedido.Preciost = Convert.ToDecimal(dgvPedido.Rows[i].Cells[10].Value.ToString().Trim().Replace("S/", ""));

                                        detpedido.Codusuario = Session.CodUsuario;

                                        pedido.ListaDetallePedido.Add(detpedido);
                                        j++;
                                        i = i + 1;

                                    }
                                    else
                                    {
                                        break;
                                    }
                                }

                                i = i + 2;

                                //pedido.Subtotal = Convert.ToDecimal(dgvPedido.Rows[i].Cells[10].Value.ToString().Trim().Replace("S/ ", ""));
                                pedido.Subtotal = Convert.ToDecimal(dgvPedido.Rows[i].Cells[10].Value.ToString().Trim().Replace("S/", ""));
                                i = i + 1;
                                //pedido.Igv = Convert.ToDecimal(dgvPedido.Rows[i].Cells[10].Value.ToString().Trim().Replace("S/ ", ""));
                                pedido.Igv = Convert.ToDecimal(dgvPedido.Rows[i].Cells[10].Value.ToString().Trim().Replace("S/", ""));
                                i = i + 1;
                                //pedido.Total = Convert.ToDecimal(dgvPedido.Rows[i].Cells[10].Value.ToString().Trim().Replace("S/ ", ""));
                                pedido.Total = Convert.ToDecimal(dgvPedido.Rows[i].Cells[10].Value.ToString().Trim().Replace("S/", ""));


                                if (pedido.Total > 0)
                                {
                                    rpta = CPedido.insertar(pedido);

                                    if (rpta == true)
                                    {
                                        cantidad = cantidad + 1;

                                    }
                                    else
                                    {
                                        listBox1.Items.Add(pedido.Promotor + "  " + detpedido.Producto + " TALLA: " + detpedido.Talla + "\n");
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " " + pedido.Promotor, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Cursor = Cursors.Default;
            }
        }
          
        */


        private void frmPedido_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
