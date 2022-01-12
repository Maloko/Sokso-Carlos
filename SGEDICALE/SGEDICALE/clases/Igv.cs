using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGEDICALE.clases
{
    public class Igv
    {

        private int igvid;
        private decimal valor;
        private decimal valorinverso;
        private int anho;
        private int estado;

        public int Igvid
        {
            get
            {
                return igvid;
            }

            set
            {
                igvid = value;
            }
        }

        public decimal Valor
        {
            get
            {
                return valor;
            }

            set
            {
                valor = value;
            }
        }

        public decimal Valorinverso
        {
            get
            {
                return valorinverso;
            }

            set
            {
                valorinverso = value;
            }
        }

        public int Anho
        {
            get
            {
                return anho;
            }

            set
            {
                anho = value;
            }
        }

        public int Estado
        {
            get
            {
                return estado;
            }

            set
            {
                estado = value;
            }
        }
    }
}
