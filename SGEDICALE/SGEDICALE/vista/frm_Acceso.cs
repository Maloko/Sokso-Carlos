using DevComponents.DotNetBar;
using SGEDICALE.clases;
using SGEDICALE.controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGEDICALE.vista
{
    public partial class frm_Acceso : DevComponents.DotNetBar.Office2007Form
    {

        private Usuario usuario = null;
        private CUsuario cusu = new CUsuario();
        private List<Usuario> lista_usuario = null;
        private List<Acceso> lista_acceso = null;
        private List<Acceso> lista_acceso_asignado = null;
        private Acceso acceso = null;
        private CAcceso cacceso = new CAcceso();


        public frm_Acceso()
        {
            InitializeComponent();
        }

        private void frm_Acceso_Load(object sender, EventArgs e)
        {
            cargar_usuario();
            cargar_formulario_acceso();
            cargar_formulario_acceso_xusuario();
        }


        public void cargar_formulario_acceso_xusuario()
        {

            list_accede.Items.Clear();
            acceso = new Acceso();
            acceso.Usuario = lista_usuario[cb_usuario.SelectedIndex];
            lista_acceso_asignado = CAcceso.listar_acceso_aformulario_xusuario(acceso);

            if (lista_acceso_asignado != null)
            {

                if (lista_acceso_asignado.Count > 0)
                {

                    foreach (Acceso a in lista_acceso_asignado)
                    {

                        list_accede.Items.Add(a.Nombre);
                    }

                }
            }
        }


        public void cargar_usuario()
        {

            cb_usuario.Items.Clear();
            lista_usuario = CUsuario.listar_usuario_acceso();

            if (lista_usuario != null)
            {

                if (lista_usuario.Count > 0)
                {
                    foreach (Usuario u in lista_usuario)
                    {
                        cb_usuario.Items.Add(u.Cuenta);
                    }

                    cb_usuario.SelectedIndex = 0;
                }
            }
        }

        public void cargar_formulario_acceso()
        {

            list_formulario.Items.Clear();
            lista_acceso = CAcceso.listar_acceso_aformulario();

            if (lista_acceso != null)
            {

                if (lista_acceso.Count > 0)
                {

                    foreach (Acceso a in lista_acceso)
                    {

                        list_formulario.Items.Add(a.Nombre);
                    }

                }
            }
        }

        private void cb_usuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            list_accede.Items.Clear();
            cargar_formulario_acceso_xusuario();
        }

        private void btn_agregar_todo_Click(object sender, EventArgs e)
        {
            if (list_formulario.Items.Count > 0)
            {

                asignar_todos();

            }
        }


        public void asignar_todos()
        {
            bool todocorrecto = true;

            if (lista_acceso != null)
            {

                if (lista_acceso.Count > 0)
                {


                    foreach (Acceso a in lista_acceso)
                    {

                        
                        a.Usuario = usuario;
                        a.Usuario = lista_usuario[cb_usuario.SelectedIndex];
                        a.Estado = 1;

                        if (!CAcceso.existe_acceso_aformulario(a))
                        {
                            if (CAcceso.registar_acceso_aformulario(a) < 0)
                            {

                                todocorrecto = false;
                                break;
                            }
                        }
                        else
                        {

                            if (CAcceso.actualizar_acceso_aformulario(a) < 0)
                            {

                                todocorrecto = false;
                                break;
                            }

                        }

                    }

                    if (todocorrecto)
                    {
                        MessageBoxEx.Show("Se asignaron los accesos de forma correcta...", "Información");
                    }
                    else
                    {

                        MessageBoxEx.Show("Problemas al asignar accesos..", "Advertencia");

                    }

                    cargar_formulario_acceso_xusuario();
                }
            }

        }

        private void btn_agregar_uno_Click(object sender, EventArgs e)
        {
            if (list_formulario.SelectedItems.Count > 0)
            {

                asignar_uno();

            }
        }


        public void asignar_uno()
        {

            if (lista_acceso != null)
            {
                if (lista_acceso.Count > 0)
                {

                    acceso = lista_acceso[list_formulario.SelectedIndex];
                 
                    acceso.Usuario = usuario;
                    acceso.Usuario = lista_usuario[cb_usuario.SelectedIndex];
                    acceso.Estado = 1;

                    if (!CAcceso.existe_acceso_aformulario(acceso))
                    {
                        if (CAcceso.registar_acceso_aformulario(acceso) > 0)
                        {
                            MessageBoxEx.Show("Se asigno el acceso de forma correcta...", "Información");
                        }
                        else
                        {
                            MessageBoxEx.Show("Problemas al asignar acceso..", "Advertencia");
                        }

                        cargar_formulario_acceso_xusuario();
                    }
                    else
                    {

                        if (CAcceso.actualizar_acceso_aformulario(acceso) > 0)
                        {

                            MessageBoxEx.Show("Se asigno el acceso de forma correcta...", "Información");
                        }
                        else
                        {

                            MessageBoxEx.Show("Problemas al asignar el acceso..", "Advertencia");

                        }

                        cargar_formulario_acceso_xusuario();

                    }
                }
            }

        }

        private void btn_quitar_uno_Click(object sender, EventArgs e)
        {
            if (list_accede.SelectedItems.Count > 0)
            {

                quitar_uno();

            }
        }


        public void quitar_uno()
        {

            if (lista_acceso_asignado != null)
            {
                if (lista_acceso_asignado.Count > 0)
                {

                    acceso = lista_acceso_asignado[list_accede.SelectedIndex];
                 
                    acceso.Usuario = usuario;
                    acceso.Usuario = lista_usuario[cb_usuario.SelectedIndex];
                    acceso.Estado = 0;

                    if (CAcceso.actualizar_acceso_aformulario(acceso) > 0)
                    {
                        MessageBoxEx.Show("Se retiro el acceso de forma correcta...", "Información");
                        cargar_formulario_acceso_xusuario();
                    }
                    else
                    {
                        MessageBoxEx.Show("Problemas al retirar el acceso..", "Advertencia");
                        cargar_formulario_acceso_xusuario();
                    }
                }
            }

        }

        private void btn_quitar_todo_Click(object sender, EventArgs e)
        {
            if (list_accede.Items.Count > 0)
            {

                quitar_todos();

            }
        }

        public void quitar_todos()
        {
            bool todocorrecto = true;

            if (lista_acceso_asignado != null)
            {

                if (lista_acceso_asignado.Count > 0)
                {

                    foreach (Acceso a in lista_acceso_asignado)
                    {

                      
                        a.Usuario = usuario;
                        a.Usuario = lista_usuario[cb_usuario.SelectedIndex];
                        a.Estado = 0;

                        if (CAcceso.actualizar_acceso_aformulario(a) < 0)
                        {
                            todocorrecto = false;
                            break;
                        }

                    }

                    if (todocorrecto)
                    {
                        MessageBoxEx.Show("Se retiro la asignación accesos de forma correcta...", "Información");
                    }
                    else
                    {

                        MessageBoxEx.Show("Problemas al retirar accesos..", "Advertencia");

                    }

                    cargar_formulario_acceso_xusuario();
                }
            }

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
