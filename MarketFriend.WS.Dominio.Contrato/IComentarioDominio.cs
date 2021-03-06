﻿using System;
using System.Collections.Generic;
using System.Text;
using MarketFriend.WS.Modelo.Response;

namespace MarketFriend.WS.Dominio.Contrato
{
    public interface IComentarioDominio:IDisposable
    {
        IEnumerable<MKFComentarioResponse> TraerTodos(int codigoComercio);
    }
}
