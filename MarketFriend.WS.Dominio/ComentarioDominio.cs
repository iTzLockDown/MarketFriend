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
            using (IComentarioRepositorio oDominio = new ComentarioRepositorio())
            {
                oLista = oDominio.TraertTodos(codigoComercio).ToList();
            }

            return oLista;
        }
    }
}
