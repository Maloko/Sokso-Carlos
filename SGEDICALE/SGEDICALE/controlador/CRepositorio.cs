using System;
using System.Collections.Generic;
using System.Data;
using SGEDICALE.modelo;
using SGEDICALE.clases;

namespace SGEDICALE.controlador
{
    public class CRepositorio
    {
        public static bool registra_repositorio(Repositorio repo)
        {
            return MRepositorio.registra_repositorio(repo);
        }

        public static bool registra_repositorioRespaldo(Repositorio repo)
        {
            return MRepositorio.registra_repositorioRespaldo(repo);
        }

        public static List<Repositorio> buscar_repositorio(Repositorio repo)
        {
            return MRepositorio.buscar_repositorio(repo);
        }

        public static Repositorio buscarComprobantexidRepo(int idrepo)
        {
            return MRepositorio.buscarComprobantexidRepo(idrepo);
        }


        public static int ContadorNoEnviados()
        {
            return MRepositorio.ContadorNoEnviados();
        }

        public static int ValidarEnviosPendientes()
        {
            return MRepositorio.ValidarEnviosPendientes();
        }


        public static bool update(string valor)
        {
            return MRepositorio.update(valor);
        }


        public static Repositorio buscarComprobante(Comprobantee comprobante)
        {
            return MRepositorio.buscarComprobante(comprobante);
        }

        public static Repositorio buscarComprobante2(Comprobantee comprobante)
        {
            return MRepositorio.buscarComprobante2(comprobante);
        }

        public static Repositorio buscarComprobanteNotaCredito(Comprobantee comprobante)
        {
            return MRepositorio.buscarComprobanteNotaCredito(comprobante);
        }


        public static List<Repositorio> listar_repositorio_filtrado(String estado, Int32 codsucu, Int32 codalma, DateTime FechaInicial, DateTime FechaFinal)
        {
            return MRepositorio.listar_repositorio_filtrado(estado, codsucu, codalma, FechaInicial, FechaFinal);
        }

        public static List<Repositorio> listar_repositorio(String estado, Int32 codsucu, Int32 codalma, DateTime fecha)
        {
            return MRepositorio.listar_repositorio(estado, codsucu, codalma, fecha);
        }

        public static bool actualiza_repositorio(Repositorio repo)
        {
            return MRepositorio.actualiza_repositorio(repo);
        }

        public static bool actualiza_repositorio_respaldo(Repositorio repo)
        {
            return MRepositorio.actualiza_repositorio_respaldo(repo);
        }

        public static bool actualiza_repositorio_xml(Repositorio repo)
        {
            return MRepositorio.actualiza_repositorio_xml(repo);
        }

        


        public static bool ActualizaCorrelativoDocResp(Int32 codtipodoc, Int32 codalma)
        {
            return MRepositorio.ActualizaCorrelativoDocResp(codtipodoc, codalma);
        }

        public static List<Repositorio> listar_repositorio_Enviados(String estado, Int32 codsucu, Int32 codalma, DateTime fecha)
        {
            return MRepositorio.listar_repositorio_Enviados(estado, codsucu, codalma, fecha);
        }

        public static DataTable Lista_Ventas_Diarias(Int32 iCodSucursal, Int32 iCodAlmacen, DateTime fecha)
        {
            return MRepositorio.Lista_Ventas_Diarias(iCodSucursal, iCodAlmacen, fecha);
        }
    }
}
