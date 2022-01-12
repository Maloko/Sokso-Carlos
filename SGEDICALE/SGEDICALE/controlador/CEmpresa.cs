using System;
using System.Windows.Forms;
using SGEDICALE.modelo;
using SGEDICALE.clases;


namespace SGEDICALE.controlador
{
    public class CEmpresa
    {

        public static Boolean insert(Empresa emp)
        {
            try
            {
                return MEmpresa.Insert(emp);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("Duplicate entry")) DevComponents.DotNetBar.MessageBoxEx.Show("Se encontró el siguiente problema: N°- de Documento Repetido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                else DevComponents.DotNetBar.MessageBoxEx.Show("Se encontró el siguiente problema: " + ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        public static Empresa CargaEmpresa()
        {
           return MEmpresa.CargaEmpresa();

        }


        public static Boolean update(Empresa emp)
        {
            try
            {
                return MEmpresa.Update(emp);
            }
            catch (Exception ex)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Se encontró el siguiente problema: " + ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }




        /*

        public static Boolean update(Empresa emp)
        {
            try
            {
                return MEmpresa.Update(emp);
            }
            catch (Exception ex)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Se encontró el siguiente problema: " + ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        public static Boolean delete(Int32 Codemp)
        {
            try
            {
                return MEmpresa.Delete(Codemp);
            }
            catch (Exception ex)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Se encontró el siguiente problema: " + ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        public static DataTable CargaEmpresas()
        {
            try
            {
                return MEmpresa.CargaEmpresas();
            }
            catch (Exception ex)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Se encontró el siguiente problema: " + ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }

        public static DataTable MuestraEmpresas()
        {
            try
            {
                return MEmpresa.ListaEmpresas();
            }
            catch (Exception ex)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Se encontró el siguiente problema: " + ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }

        public static Empresa CargaEmpresa(Int32 CodEmpresa)
        {
            try
            {
                return MEmpresa.CargaEmpresa(CodEmpresa);
            }
            catch (Exception ex)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Se encontró el siguiente problema: " + ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }
        public static Empresa CargaEmpresa3(Int32 CodEmpresa)
        {
            try
            {
                return MEmpresa.CargaEmpresa3(CodEmpresa);
            }
            catch (Exception ex)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Se encontró el siguiente problema: " + ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }

        public static Boolean VerificaRUC(String RUC)
        {
            try
            {
                return MEmpresa.VerificaRUC(RUC);
            }
            catch (Exception ex)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Se encontró el siguiente problema: " + ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }


        public static Boolean UpdateConfiguracion(clsParametro param, Int32 iCodEmpresa)
        {
            try
            {
                return MEmpresa.UpdateConfiguracion(param, iCodEmpresa);
            }
            catch (Exception ex)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Se encontró el siguiente problema: " + ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }


        public static clsParametros CargaConfiguracion(int iCodEmpresa)
        {
            try
            {
                return MEmpresa.CargaConfiguracion(iCodEmpresa);
            }
            catch (Exception ex)
            {
                DevComponents.DotNetBar.MessageBoxEx.Show("Se encontró el siguiente problema: " + ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }

        public static DataTable MuestraParametros(Int32 icodEmpresa)
        {
            try
            {
                return MEmpresa.MuestraParametros(icodEmpresa);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se encontró el siguiente problema: " + ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }*/


    }
}
