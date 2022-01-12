using System.Collections.Generic;
using System.Data;
using SGEDICALE.modelo;
using SGEDICALE.clases;
using System;

namespace SGEDICALE.controlador
{
    public class CTipoTarjeta
    {

        public static DataTable CargaTipoTarjeta()
        {
            return MTipoTarjeta.CargaTipoTarjeta();

        }

        public static DataTable ListadoTipoTarjeta()
        {
            return MTipoTarjeta.ListadoTipoTarjeta();

        }

        public static bool Insert(TipoTarjeta tar)
        {
           
                return MTipoTarjeta.Insert(tar);
  
        }

        public static  Boolean Update(TipoTarjeta tar)
        {
          
                return MTipoTarjeta.Update(tar);

        }

        public static Boolean Delete(Int32 Codtar)
        {
            
                return MTipoTarjeta.Delete(Codtar);

        }

        public static TipoTarjeta buscar(Int32 Codigo)
        {
           return MTipoTarjeta.buscar(Codigo);

        }

    }
}
