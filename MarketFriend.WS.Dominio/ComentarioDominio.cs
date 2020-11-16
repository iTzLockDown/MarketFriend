using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MarketFriend.WS.Dominio.Contrato;
using MarketFriend.WS.Modelo.Response;
using MarketFriend.WS.Repositorio.Contrato;

namespace MarketFriend.WS.Dominio
{
    public class ComentarioDominio : IComentarioDominio
    {
        public IEnumerable<MKFComentarioResponse> TraertTodos(int codigoComercio)
        {
            IEnumerable<MKFComentarioResponse> oLista = null;
            using (IComentarioRepositorio oRepositorio = new ComentarioRepositorio())
            {
                oLista = oRepositorio.TraertTodos(codigoComercio).ToList();
            }

            return oLista;
        }
    }
}
