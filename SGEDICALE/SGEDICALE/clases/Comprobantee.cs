using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGEDICALE.clases
{
    public class Comprobantee
    {
        public Comprobantee()
        {

            ListaDetalleComprobante = new List<DetalleComprobante>();
          
        }

        private int codComprobante;
        private int codPedido;
        private int codTransaccion;
        private int codTipoComprobante;
        private string scomprobante;
        private string siglacomprobante;
        private int codserie;
        private string serie;
        private int codpromotor;

        private string razonsocialcliente;
        private string nombre;
        private string numdoc;
        private string direccion;


        private int codmoneda;
        private decimal tipocambio;
        private string descripcion;
        private DateTime fechaemision;
        private DateTime fechavencimiento;
        private decimal descuento;
        private decimal subtotal;
        private decimal igv;
        private decimal total;



        private decimal gravadas;
        private decimal gratuitas;
        private decimal exoneradas;
        private decimal inafectas;

        private decimal abonado;
        private decimal pendiente;
        private int situacionpago;
        private int formapago;
        private DateTime fechapago;

        private int anulado;
        private int codNotaCredito;
        private string documentoreferencia;


        private String tipoDocumentoAnticipo;
        private String documentoReferenciaAnticipo;
        private Decimal montoAnticipo;



        private int codempresa;
        private int codusuario;
        private DateTime fecharegistro;
        private int estado;
        private int estadopedido;

        private List<DetalleComprobante> listaDetalleComprobante;


        private string SiglaTransaccion;
        private string DescripcionTransaccion;

        private Comprobantee comprobanterelacionado;

        private int coddiscrepancia;





        public int CodComprobante
        {
            get
            {
                return codComprobante;
            }

            set
            {
                codComprobante = value;
            }
        }

        public int CodPedido
        {
            get
            {
                return codPedido;
            }

            set
            {
                codPedido = value;
            }
        }

        public int CodTransaccion
        {
            get
            {
                return codTransaccion;
            }

            set
            {
                codTransaccion = value;
            }
        }

        public int CodTipoComprobante
        {
            get
            {
                return codTipoComprobante;
            }

            set
            {
                codTipoComprobante = value;
            }
        }

        public string Scomprobante
        {
            get
            {
                return scomprobante;
            }

            set
            {
                scomprobante = value;
            }
        }

        public string Siglacomprobante
        {
            get
            {
                return siglacomprobante;
            }

            set
            {
                siglacomprobante = value;
            }
        }

        public int Codserie
        {
            get
            {
                return codserie;
            }

            set
            {
                codserie = value;
            }
        }

        public string Serie
        {
            get
            {
                return serie;
            }

            set
            {
                serie = value;
            }
        }


        public string Razonsocialcliente
        {
            get
            {
                return razonsocialcliente;
            }

            set
            {
                razonsocialcliente = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string Numdoc
        {
            get
            {
                return numdoc;
            }

            set
            {
                numdoc = value;
            }
        }

        public string Direccion
        {
            get
            {
                return direccion;
            }

            set
            {
                direccion = value;
            }
        }

        public int Codmoneda
        {
            get
            {
                return codmoneda;
            }

            set
            {
                codmoneda = value;
            }
        }

        public decimal Tipocambio
        {
            get
            {
                return tipocambio;
            }

            set
            {
                tipocambio = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return descripcion;
            }

            set
            {
                descripcion = value;
            }
        }

        public DateTime Fechaemision
        {
            get
            {
                return fechaemision;
            }

            set
            {
                fechaemision = value;
            }
        }

        public DateTime Fechavencimiento
        {
            get
            {
                return fechavencimiento;
            }

            set
            {
                fechavencimiento = value;
            }
        }

        public decimal Descuento
        {
            get
            {
                return descuento;
            }

            set
            {
                descuento = value;
            }
        }

        public decimal Subtotal
        {
            get
            {
                return subtotal;
            }

            set
            {
                subtotal = value;
            }
        }

        public decimal Igv
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

        public decimal Total
        {
            get
            {
                return total;
            }

            set
            {
                total = value;
            }
        }

        public decimal Gravadas
        {
            get
            {
                return gravadas;
            }

            set
            {
                gravadas = value;
            }
        }

        public decimal Gratuitas
        {
            get
            {
                return gratuitas;
            }

            set
            {
                gratuitas = value;
            }
        }

        public decimal Exoneradas
        {
            get
            {
                return exoneradas;
            }

            set
            {
                exoneradas = value;
            }
        }

        public decimal Inafectas
        {
            get
            {
                return inafectas;
            }

            set
            {
                inafectas = value;
            }
        }

        public decimal Abonado
        {
            get
            {
                return abonado;
            }

            set
            {
                abonado = value;
            }
        }

        public decimal Pendiente
        {
            get
            {
                return pendiente;
            }

            set
            {
                pendiente = value;
            }
        }

        public int Situacionpago
        {
            get
            {
                return situacionpago;
            }

            set
            {
                situacionpago = value;
            }
        }

        public int Formapago
        {
            get
            {
                return formapago;
            }

            set
            {
                formapago = value;
            }
        }

        public DateTime Fechapago
        {
            get
            {
                return fechapago;
            }

            set
            {
                fechapago = value;
            }
        }

        public int Anulado
        {
            get
            {
                return anulado;
            }

            set
            {
                anulado = value;
            }
        }

        public int CodNotaCredito
        {
            get
            {
                return codNotaCredito;
            }

            set
            {
                codNotaCredito = value;
            }
        }

        public string Documentoreferencia
        {
            get
            {
                return documentoreferencia;
            }

            set
            {
                documentoreferencia = value;
            }
        }

        public string TipoDocumentoAnticipo
        {
            get
            {
                return tipoDocumentoAnticipo;
            }

            set
            {
                tipoDocumentoAnticipo = value;
            }
        }

        public string DocumentoReferenciaAnticipo
        {
            get
            {
                return documentoReferenciaAnticipo;
            }

            set
            {
                documentoReferenciaAnticipo = value;
            }
        }

        public decimal MontoAnticipo
        {
            get
            {
                return montoAnticipo;
            }

            set
            {
                montoAnticipo = value;
            }
        }

        public int Codempresa
        {
            get
            {
                return codempresa;
            }

            set
            {
                codempresa = value;
            }
        }

        public int Codusuario
        {
            get
            {
                return codusuario;
            }

            set
            {
                codusuario = value;
            }
        }

        public DateTime Fecharegistro
        {
            get
            {
                return fecharegistro;
            }

            set
            {
                fecharegistro = value;
            }
        }



        public List<DetalleComprobante> ListaDetalleComprobante
        {
            get
            {
                return listaDetalleComprobante;
            }

            set
            {
                listaDetalleComprobante = value;
            }
        }

        public string SiglaTransaccion1
        {
            get
            {
                return SiglaTransaccion;
            }

            set
            {
                SiglaTransaccion = value;
            }
        }

        public string DescripcionTransaccion1
        {
            get
            {
                return DescripcionTransaccion;
            }

            set
            {
                DescripcionTransaccion = value;
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

        public Comprobantee Comprobanterelacionado
        {


            get
            {
                return comprobanterelacionado;
            }

            set
            {
                comprobanterelacionado = value;
            }

        }

        public int Coddiscrepancia { get => coddiscrepancia; set => coddiscrepancia = value; }
        public int Estadopedido { get => estadopedido; set => estadopedido = value; }
        public int Codpromotor { get => codpromotor; set => codpromotor = value; }
    }
}
