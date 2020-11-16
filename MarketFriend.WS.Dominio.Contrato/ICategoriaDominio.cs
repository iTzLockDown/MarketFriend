using System;
using System.Collections.Generic;
using System.Text;
using MarketFriend.WS.Modelo.Request;
using MarketFriend.WS.Modelo.Response;

namespace MarketFriend.WS.Dominio.Contrato
{
    public interface ICategoriaDominio
    {
        IEnumerable<MKFCategoriaResponse> TraerTodos();
        bool GrabarEditar(MKFCategoriaRequest oCategoria);
        MKFCategoriaResponse TraerUno(int codigoCategoria);
        bool Eliminar(int codigoCategoria);
        bool Habilitar(int codigoCategoria);
    }
}
