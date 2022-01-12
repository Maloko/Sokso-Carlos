using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGEDICALE.clases
{
    public class DetallePrecio
    {

        private int codDetallePrecio;
        private Precio precio;

        private int pag;
        private string marca;
        private string modelo;
        private string color;
        private string tallas;
        private decimal ppromotor;
        private decimal pcliente;
        private decimal pdirector;
        private string fechallegada;
        private string talladisponible;
        private string tallasagotadas;
        private int codusuario;
        private DateTime fechaRegistro;
        private Boolean estado;

        public int CodDetallePrecio { get => codDetallePrecio; set => codDetallePrecio = value; }
        public Precio Precio { get => precio; set => precio = value; }
        public int Pag { get => pag; set => pag = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string Color { get => color; set => color = value; }
        public string Tallas { get => tallas; set => tallas = value; }
        public decimal Ppromotor { get => ppromotor; set => ppromotor = value; }
        public decimal Pcliente { get => pcliente; set => pcliente = value; }
        public decimal Pdirector { get => pdirector; set => pdirector = value; }
        public string Fechallegada { get => fechallegada; set => fechallegada = value; }
        public string Talladisponible { get => talladisponible; set => talladisponible = value; }
        public string Tallasagotadas { get => tallasagotadas; set => tallasagotadas = value; }
        public int Codusuario { get => codusuario; set => codusuario = value; }
        public DateTime FechaRegistro { get => fechaRegistro; set => fechaRegistro = value; }
        public bool Estado { get => estado; set => estado = value; }
    }
}
