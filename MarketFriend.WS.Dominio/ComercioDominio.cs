using System;
using System.Collections.Generic;
using System.Text;
using MarketFriend.WS.Dominio.Contrato;
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

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
