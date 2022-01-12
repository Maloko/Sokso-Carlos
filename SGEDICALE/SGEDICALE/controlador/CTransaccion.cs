using System;
using SGEDICALE.clases;
using SGEDICALE.modelo;


namespace SGEDICALE.controlador
{
    public class CTransaccion
    {
        public static Transaccion MuestraTransaccion(Int32 Codigo)
        {
           
                return MTransaccion.CargaTransaccion(Codigo);

        }

    }
}
