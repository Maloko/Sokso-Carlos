using System;
using System.Data;
using SGEDICALE.modelo;
using SGEDICALE.clases;

namespace SGEDICALE.controlador
{
    public class CPedido
    {
        public static DataTable cargarGrilla(string ruta_excel, string nombre_excel)
        {
            return MPedido.cargarGrilla(ruta_excel, nombre_excel);
        }


        public static bool insertar(Pedido pedido)
        {
            return MPedido.insertar(pedido);
        }

        public static DataTable cargarComboPedido(DateTime fechapedido)
        {
            return MPedido.cargarComboPedido(fechapedido);
        }

        public static DataTable cargarComboPedidoxMes(DateTime fechapedido)
        {
            return MPedido.cargarComboPedidoxMes(fechapedido);
        }


        public static DataTable listarPedidosxCodigo(int numeropedido)
        {
            return MPedido.listarPedidosxCodigo(numeropedido);
        }

        public static DataTable listarPedidos()
        {
            return MPedido.listarPedidos();
        }

        public static DataTable listarPedidosxPromotor_Fecha_Filtro(int cod,string filtro)
        {
            return MPedido.listarPedidosxPromotor_Fecha_Filtro(cod,filtro);
        }

        public static DataTable listarPedidosFiltro(string numeropedido, int filtro)
        {
            return MPedido.listarPedidosFiltro(numeropedido,filtro);
        }

        public static DataTable listarPedidosFiltroTodos(string numeropedido, int filtro)
        {
            return MPedido.listarPedidosFiltroTodos(numeropedido, filtro);
        }

        public static DataTable listarPedidosFiltroDiferencia(string numeropedido,int filtro)
        {
            return MPedido.listarPedidosFiltroDiferencia(numeropedido,filtro);
        }


        public static DataTable listarPedidosFiltroCorrecto(string numeropedido, int filtro)
        {
            return MPedido.listarPedidosFiltroCorrecto(numeropedido, filtro);
        }

        public static Pedido buscar(int codpedido)
        {
            return MPedido.buscar(codpedido);
        }

        public static bool borrar(int codpedido)
        {
            return MPedido.borrar(codpedido);
        }

        public static bool borrarTodo(int numeropedido)
        {
            return MPedido.borrarTodo(numeropedido);
        }



    }
}
