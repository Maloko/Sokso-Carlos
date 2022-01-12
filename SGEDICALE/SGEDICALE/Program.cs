using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGEDICALE
{
    static class Program
    {

        public static string CarpetaCdr => "./documentos/CDR";
        public static string CarpetaBoletas => "./documentos/Boletas";
        public static string CarpetaFacturas => "./documentos/Facturas";
        public static string CarpetaNC => "./documentos/NC";
        public static string CarpetaND => "./documentos/ND";


        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {


            if (!Directory.Exists(CarpetaCdr))
                Directory.CreateDirectory(CarpetaCdr);

            if (!Directory.Exists(CarpetaBoletas))
                Directory.CreateDirectory(CarpetaBoletas);

            if (!Directory.Exists(CarpetaFacturas))
                Directory.CreateDirectory(CarpetaFacturas);

            if (!Directory.Exists(CarpetaNC))
                Directory.CreateDirectory(CarpetaNC);

            if (!Directory.Exists(CarpetaND))
                Directory.CreateDirectory(CarpetaND);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("es-PE");
            Application.Run(new frmLogin());
        }
    }
}
