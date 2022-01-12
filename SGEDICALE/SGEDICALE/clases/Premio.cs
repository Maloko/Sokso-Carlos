using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGEDICALE.clases
{
    public class Premio
    {
        private int codPremio;
        private string dni;
        private string promotor;
        private int codCampaña;
        private string campaña;
        private int codPromotor;
        private string compraFacturada;
        private string FechaValidacion;
        private string premioRegular;
        private string envioPremioRegular;
        private string premioAfi;
        private string valido;
        private int codusuario;
        private DateTime fecharegistro;
        private DateTime fechaentrega;
        private int estado;

        private int entregado;
        


        public int CodPremio { get => codPremio; set => codPremio = value; }
        public int CodCampaña { get => codCampaña; set => codCampaña = value; }
        public int CodPromotor { get => codPromotor; set => codPromotor = value; }
        public string CompraFacturada { get => compraFacturada; set => compraFacturada = value; }
        public string FechaValidacion1 { get => FechaValidacion; set => FechaValidacion = value; }
        public string PremioRegular { get => premioRegular; set => premioRegular = value; }
        public string EnvioPremioRegular { get => envioPremioRegular; set => envioPremioRegular = value; }
        public string PremioAfi { get => premioAfi; set => premioAfi = value; }
        public string Valido { get => valido; set => valido = value; }
        public int Codusuario { get => codusuario; set => codusuario = value; }
        public DateTime Fecharegistro { get => fecharegistro; set => fecharegistro = value; }
        public int Estado { get => estado; set => estado = value; }
        public string Dni { get => dni; set => dni = value; }
        public string Promotor { get => promotor; set => promotor = value; }
        public string Campaña { get => campaña; set => campaña = value; }
        public int Entregado { get => entregado; set => entregado = value; }
        public DateTime Fechaentrega { get => fechaentrega; set => fechaentrega = value; }
    }
}
