﻿using System;
using System.Collections.Generic;
using System.Text;
using MarketFriend.WS.Modelo.Request;
using MarketFriend.WS.Modelo.Response;

namespace MarketFriend.WS.Dominio.Contrato
{
    public interface IComercioDominio:IDisposable
    {
        IEnumerable<MKFComercioResponse> TraerTodos();
        IEnumerable<MKFComercioResponse> TraerProximo(double GpsLatitud, double GpsLongitud);
        bool GrabarEditar(MKFComercioRequest oComercio);
        bool Eliminar(int codigoComercio);
        bool Habilitar(int codigoComercio);
        MKFComercioResponse TraerUno(int codigoComercio);
        IEnumerable<MKFComercioResponse> TraerCategoria(int codigoCategoria);
        MKFComercioResponse TraerMejorCalificado(float gpsLatitud, float gpsLongitud);
        IEnumerable<MKFMensajeResponse> CalificaComercio(MKFClasificacionRequest oCalifica);
        IEnumerable<MKFComercioResponse> TraerNombre(string nombreComercio);

    }
}
