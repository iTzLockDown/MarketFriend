using System;
using System.Collections.Generic;
using System.Text;
using MarketFriend.WS.Modelo.Response;

namespace MarketFriend.WS.Repositorio.Contrato
{
    public interface IComercioRepositorio :IDisposable
    {
        public IEnumerable<MKFComercioResponse> TraerTodos();
    }
}
