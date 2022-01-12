using System;
using System.Collections.Generic;
using System.Data;
using SGEDICALE.modelo;
using SGEDICALE.clases;


namespace SGEDICALE.controlador
{
    public class CCuenta
    {


        public static Boolean Insert(Cuenta cta)
        {
          return MCuenta.Insert(cta);
        }

        public static DataTable listar()
        {
            return MCuenta.listar();
        }

        public static DataTable buscarxcodbanco(int codbanco)
        {
            return MCuenta.buscarxcodbanco(codbanco);
        }

        public static Cuenta buscar(int cod)
        {
            return MCuenta.buscar(cod);
        }


        public static Boolean Update(Cuenta cta)
        {
            
                return MCuenta.Update(cta);

        }

        public static Boolean Delete(Int32 CodCtaCte)
        {
            
                return MCuenta.Delete(CodCtaCte);

        }



    }
}
