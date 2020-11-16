using System;
using System.Collections.Generic;
using System.Text;
using MarketFriend.WS.Modelo.Response;

namespace MarketFriend.WS.Repositorio.Contrato
{
    public interface IComentarioRepositorio:IDisposable
    {
        IEnumerable<MKFComentarioResponse> TraertTodos(int codigoComercio);
    }
}
