using System;
using System.Collections.Generic;
using System.Text;
using MarketFriend.WS.Modelo.Request;
using MarketFriend.WS.Modelo.Response;

namespace MarketFriend.WS.Repositorio.Contrato
{
    public interface ICategoriaRepositorio:IDisposable
    {
        IEnumerable<MKFCategoriaResponse> TraerTodos();
        bool GrabarEditar(MKFCategoriaRequest oCategoria);
        MKFCategoriaResponse TraerUno(int codigoCategoria);
        bool Eliminar(int codigoCategoria);
        bool Habilitar(int codigoCategoria);

    }
}
