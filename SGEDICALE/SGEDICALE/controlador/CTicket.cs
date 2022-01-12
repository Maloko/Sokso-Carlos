using SGEDICALE.clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGEDICALE.modelo;
using SGEDICALE.clases;
using System.Data;

namespace SGEDICALE.controlador
{
    public class CTicket
    {


        public static bool insertar(Ticket ticket)
        {
            return MTicket.insertar(ticket);
        }

        public static  Ticket buscaticket(int codticket)
        {
            return MTicket.buscaticket(codticket);
        }



        public static int anular_ticket(Ticket ticket, Usuario usureg)
        {
            return MTicket.anular_ticket(ticket, usureg);
        }



        public static DataTable listar_ticket_xestado_xfecha_xcliente(DateTime fechaincio, DateTime fechafin, string promotor)
        {

            return MTicket.listar_ticket_xestado_xfecha_xcliente(fechaincio, fechafin, promotor);
        }

        public static DataTable listar_ticket_xestado_xfecha(DateTime fechai, DateTime fechaf)
        {
            return MTicket.listar_ticket_xestado_xfecha(fechai, fechaf);

        }

        public static DataTable listar_detalle_ticket_xidticket( Ticket ticket)
        {
            return MTicket.listar_detalle_ticket_xidticket(ticket);
        }



    }
}
