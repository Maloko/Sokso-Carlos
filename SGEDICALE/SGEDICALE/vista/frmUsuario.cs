using DevComponents.DotNetBar;
using SGEDICALE.controlador;
using SGEDICALE.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalXML.vista
{
    public partial class frmUsuario : DevComponents.DotNetBar.Office2007Form
    {
        private List<TipoUsuario> lista_tipousuario = null;
        private  static CTipoUsuario admtipousu = new CTipoUsuario();
        private Usuario usuario = null;
        private CUsuario admusu = new CUsuario();
        private Encriptacion encripta =new Encriptacion();
        private DataTable usuarios = null;
        public Usuario usureg { get; set; }
        public frmUsuario()
        {
            InitializeComponent();
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            cb_estado.SelectedIndex =0;
            listar_tipousuario();
            dg_usuario.AutoGenerateColumns = false;
            txt_nombre.Focus();
        }

        private void txt_nombre_TextChanged(object sender, EventArgs e)
        {
            txt_nombre.CharacterCasing = CharacterCasing.Upper;
        }

        private void txt_documento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txt_telefono_TextChanged(object sender, EventArgs e)
        {
            txt_telefono.CharacterCasing = CharacterCasing.Upper;
        }

        private void txt_cuenta_TextChanged(object sender, EventArgs e)
        {
            txt_cuenta.CharacterCasing = CharacterCasing.Upper;
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_cod.Text.Length == 0)
                {
                    if (txt_nombre.Text.Length > 0
                        && txt_documento.Text.Length > 0
                        && txt_cuenta.Text.Length > 0
                        && txt_clave.Text.Length > 0)
                    {

                        DialogResult respuesta = MessageBox.Show("¿Desea registrar usuario?...", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (respuesta == DialogResult.Yes)
                        {
                            registrar_usuario();
                            btn_buscar.PerformClick();
                        }
                    }
                    else
                    {

                        MessageBox.Show("Por favor complete la información solicitada...", "Información");
                    }
                }
                else
                {
                    if (txt_nombre.Text.Length > 0
                        && txt_documento.Text.Length > 0
                        && txt_cuenta.Text.Length > 0
                        && txt_clave.Text.Length > 0)
                    {

                        DialogResult respuesta = MessageBox.Show("¿Desea actualizar usuario?...", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (respuesta == DialogResult.Yes)
                        {
                            actualizar_usuario();
                            btn_buscar.PerformClick();
                        }
                    }
                    else
                    {

                        MessageBox.Show("Por favor complete la información solicitada...", "Información");
                    }

                }
            }
            catch (Exception) { }
        }

        private void btn_cargar_Click(object sender, EventArgs e)
        {
            listar_usuario();
        }
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_nombre.Text.Length > 0)
                {

                    buscar_usuarioxnombreapellido();
                }
            }
            catch (Exception) { }
        }
        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void dg_usuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dg_usuario.Rows.Count > 0)
                {

                    if (e.RowIndex != -1)
                    {

                        txt_cod.Text = dg_usuario.Rows[e.RowIndex].Cells[idusuario.Index].Value.ToString();
                        cb_tipousu.SelectedValue = ((from x in lista_tipousuario
                                                     where x.Descripcion == dg_usuario.Rows[e.RowIndex].Cells[tipousuario.Index].Value.ToString()
                                                     select x.Tipousuarioid).ToList())[0];
                        txt_nombre.Text = dg_usuario.Rows[e.RowIndex].Cells[nombreyapellido.Index].Value.ToString();
                        txt_documento.Text = dg_usuario.Rows[e.RowIndex].Cells[documentoidentidad.Index].Value.ToString();
                        txt_telefono.Text = dg_usuario.Rows[e.RowIndex].Cells[telefono.Index].Value.ToString();
                        txt_cuenta.Text = dg_usuario.Rows[e.RowIndex].Cells[cuenta.Index].Value.ToString();
                        txt_clave.Text = encripta.desencriptar(dg_usuario.Rows[e.RowIndex].Cells[clave.Index].Value.ToString());
                        cb_estado.SelectedIndex = (dg_usuario.Rows[e.RowIndex].Cells[estado.Index].Value.ToString() == "ACTIVO") ? 0 : 1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /**********************Mis Metodos*************************/

        public   void listar_tipousuario() {

            try
            {




                lista_tipousuario = CTipoUsuario.listar_tipousuario(); ;

                if (lista_tipousuario != null)
                {

                    if (lista_tipousuario.Count > 0)
                    {

                        cb_tipousu.DataSource = lista_tipousuario;
                        cb_tipousu.DisplayMember = "descripcion";
                        cb_tipousu.ValueMember = "tipousuarioid";

                        cb_tipousu.SelectedIndex = 0;
                    }
                }
            }
            catch (Exception) { }
        }

        public  void registrar_usuario()
        {
            try
            {
                if (lista_tipousuario == null)
                {

                    MessageBox.Show("No se ha cargado los tipos de usuario...", "Advertencia");
                    return;
                }
                usuario = new Usuario()
                {
                    Tipousuario = lista_tipousuario[cb_tipousu.SelectedIndex],
                    Nombreapellidos = txt_nombre.Text,
                    Dni = txt_documento.Text,
                    Telefono = txt_telefono.Text,
                    Cuenta = txt_cuenta.Text,
                    Clave = encripta.encriptar(txt_clave.Text),
                    Estado = (cb_estado.Text == "ACTIVO") ? 1 : 0
                };

                
                if (CUsuario.registrar_usuario(usuario, usureg) > 0)
                {
                    MessageBox.Show("Registro correcto...", "Información");
                }
                else
                {

                    MessageBox.Show("Problemas para el registro de usuario...", "Advertencia");
                }
            }
            catch (Exception) { }
        }

        public void actualizar_usuario()
        {
            try
            {
                if (lista_tipousuario == null)
                {
                    MessageBox.Show("No se ha cargado los tipos de usuario...", "Advertencia");
                    return;
                }
                usuario = new Usuario()
                {
                    Usuarioid = int.Parse(txt_cod.Text),
                    Tipousuario = lista_tipousuario[cb_tipousu.SelectedIndex],
                    Nombreapellidos = txt_nombre.Text,
                    Dni = txt_documento.Text,
                    Telefono = txt_telefono.Text,
                    Cuenta = txt_cuenta.Text,
                    Clave = encripta.encriptar(txt_clave.Text),
                    Estado = (cb_estado.Text == "ACTIVO") ? 1 : 0
                };

                
                if (CUsuario.actualizar_usuario(usuario, usureg) > 0)
                {
                    MessageBox.Show("Actualización correcta...", "Información");
                }
                else
                {

                    MessageBox.Show("Problemas para actualizar usuario...", "Advertencia");
                }
            }
            catch (Exception) { }
        }

        public void listar_usuario() {

            try
            {
                dg_usuario.DataSource = null;
                dg_usuario.AutoGenerateColumns = false;
                usuarios = CUsuario.listar_usuario();

                if (usuarios != null)
                {

                    if (usuarios.Rows.Count > 0)
                    {

                        dg_usuario.DataSource = usuarios;
                        dg_usuario.Refresh();
                    }
                }
            }
            catch (Exception) { }

        }

        public void buscar_usuarioxnombreapellido()
        {
            try
            {
                dg_usuario.DataSource = null;

                
                usuarios = CUsuario.buscar_usuarioxnombreapellido(
                        new Usuario()
                        {

                            Nombreapellidos = txt_nombre.Text
                        }
                    );

                if (usuarios != null)
                {

                    if (usuarios.Rows.Count > 0)
                    {

                        dg_usuario.DataSource = usuarios;
                        dg_usuario.Refresh();
                    }
                }
            }
            catch (Exception) { }

        }

        

        public void limpiar() {

            try
            {
                dg_usuario.DataSource = null;
                txt_cod.Text = string.Empty;
                cb_tipousu.SelectedIndex = 0;
                txt_nombre.Text = string.Empty;
                txt_documento.Text = string.Empty;
                txt_telefono.Text = string.Empty;
                txt_cuenta.Text = string.Empty;
                txt_clave.Text = string.Empty;
                cb_estado.SelectedIndex = 0;
            }
            catch (Exception) { }
        }

        private void frmUsuario_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
            {


            }
        }
    }
}
