using System;
using System.Collections.Generic;
using System.Text;
using MarketFriend.WS.Modelo.Request;
using MarketFriend.WS.Modelo.Response;

namespace MarketFriend.WS.Repositorio.Contrato
{
    public interface IComercioRepositorio :IDisposable
    {
        IEnumerable<MKFComercioResponse> TraerTodos();
        IEnumerable<MKFComercioResponse> TraerProximo(float GpsLatitud, float GpsLongitud);
        bool GrabarEditar(MKFComercioRequest oComercio);
        bool Eliminar(int codigoComercio);
        bool Habilitar(int codigoComercio);
        MKFComercioResponse TraerUno(int codigoComercio);
        IEnumerable<MKFComercioResponse> TraerCategoria(int codigoCategoria);
        MKFComercioResponse TraerMejorCalificado(float gpsLatitud, float gpsLongitud);
        IEnumerable<MKFMensajeResponse> CalificaComercio(MKFClasificacionRequest oCalifica);

    }
}
