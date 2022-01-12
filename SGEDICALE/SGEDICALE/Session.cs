using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGEDICALE
{
    public static class Session
    {
        private static int codUsuario;
        private static int codEmpresa;
        private static string ruc;
        private static decimal igv;

        public static int CodUsuario
        {
            get
            {
                return codUsuario;
            }

            set
            {
                codUsuario = value;
            }
        }

        public static int CodEmpresa
        {
            get
            {
                return codEmpresa;
            }

            set
            {
                codEmpresa = value;
            }
        }

        public static string Ruc
        {
            get
            {
                return ruc;
            }

            set
            {
                ruc = value;
            }
        }

        public static decimal Igv
        {
            get
            {
                return igv;
            }

            set
            {
                igv = value;
            }
        }
    }
}
