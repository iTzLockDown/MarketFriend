using System;
using System.Collections.Generic;
using System.Text;
using MarketFriend.WS.Dominio.Contrato;
using MarketFriend.WS.Modelo.Request;
using MarketFriend.WS.Modelo.Response;
using MarketFriend.WS.Repositorio;
using MarketFriend.WS.Repositorio.Contrato;

namespace MarketFriend.WS.Dominio
{
    public class ComercioDominio:IComercioDominio
    {
        public IEnumerable<MKFComercioResponse> TraerTodos()
        {
            IEnumerable<MKFComercioResponse> oLista = null;
            using (IComercioRepositorio oRepositorio = new ComercioRepositorio())
            {
                oLista = oRepositorio.TraerTodos();
            }

            return oLista;
        }

        
        public IEnumerable<MKFComercioResponse> TraerProximo(double GpsLatitud, double GpsLongitud)
        {
            IEnumerable<MKFComercioResponse> oLista = null;
            using (IComercioRepositorio oRepositorio = new ComercioRepositorio())
            {
                oLista = oRepositorio.TraerProximo(GpsLatitud, GpsLongitud);
            }

            return oLista;
        }

        public bool GrabarEditar(MKFComercioRequest oComercio)
        {
            bool respuesta = false;
            using (IComercioRepositorio oRepositorio = new ComercioRepositorio())
            {
                respuesta = oRepositorio.GrabarEditar(oComercio);
            }

            return respuesta;
        }

        public bool Eliminar(int codigoComercio)
        {
            bool respuesta = false;
            using (IComercioRepositorio oRepositorio = new ComercioRepositorio())
            {
                respuesta = oRepositorio.Eliminar(codigoComercio);
            }

            return respuesta;
        }

        public bool Habilitar(int codigoComercio)
        {
            bool respuesta = false;
            using (IComercioRepositorio oRepositorio = new ComercioRepositorio())
            {
                respuesta = oRepositorio.Habilitar(codigoComercio);
            }

            return respuesta;
        }

        public MKFComercioResponse TraerUno(int codigoComercio)
        {
            MKFComercioResponse oObjeto = null;
            using (IComercioRepositorio oRepositorio = new ComercioRepositorio())
            {
                oObjeto = oRepositorio.TraerUno(codigoComercio);
            }

            return oObjeto;
        }

        public IEnumerable<MKFComercioResponse> TraerNombre(string nombreComercio)
        {
            IEnumerable<MKFComercioResponse> oObjeto = null;
            using (IComercioRepositorio oRepositorio = new ComercioRepositorio())
            {
                oObjeto = oRepositorio.TraerNombre(nombreComercio);
            }

            return oObjeto;
        }

        public IEnumerable<MKFComercioResponse> TraerCategoria(int codigoCategoria)
        {
            IEnumerable<MKFComercioResponse> oLista = null;
            using (IComercioRepositorio oRepositorio = new ComercioRepositorio())
            {
                oLista = oRepositorio.TraerCategoria(codigoCategoria);
            }

            return oLista;
        }

        public MKFComercioResponse TraerMejorCalificado(float gpsLatitud, float gpsLongitud)
        {
            MKFComercioResponse oObjeto = null;
            using (IComercioRepositorio oRepositorio = new ComercioRepositorio())
            {
                oObjeto = oRepositorio.TraerMejorCalificado(gpsLatitud, gpsLongitud);
            }

            return oObjeto;
        }

        public IEnumerable<MKFMensajeResponse> CalificaComercio(MKFClasificacionRequest oCalifica)
        {
            IEnumerable<MKFMensajeResponse> oLista = null;
            using (IComercioRepositorio oRepositorio = new ComercioRepositorio())
            {
                oLista = oRepositorio.CalificaComercio(oCalifica);
            }

            return oLista;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
