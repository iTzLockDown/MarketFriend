using System;
using System.Collections.Generic;
using System.Text;
using MarketFriend.WS.Dominio.Contrato;
using MarketFriend.WS.Modelo.Request;
using MarketFriend.WS.Modelo.Response;
using MarketFriend.WS.Repositorio.Contrato;

namespace MarketFriend.WS.Dominio
{
    public class CategoriaDominio : ICategoriaDominio
    {
        public bool Eliminar(int codigoCategoria)
        {
            bool respuesta = false;
            using (ICategoriaRepositorio oDominio = new CategoriaRepositorio())
            {
                
            }
        }

        public bool GrabarEditar(MKFCategoriaRequest oCategoria)
        {
            throw new NotImplementedException();
        }

        public bool Habilitar(int codigoCategoria)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<MKFCategoriaResponse> TraerTodos()
        {
            throw new NotImplementedException();
        }

        public MKFCategoriaResponse TraerUno(int codigoCategoria)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
