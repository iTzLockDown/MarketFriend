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
            using (ICategoriaRepositorio oRepositorio = new CategoriaRepositorio())
            {
                respuesta = oRepositorio.Eliminar(codigoCategoria);
            }

            return respuesta;
        }

        public bool GrabarEditar(MKFCategoriaRequest oCategoria)
        {
            bool respuesta = false;
            using (ICategoriaRepositorio oRepositorio = new CategoriaRepositorio())
            {
                respuesta = oRepositorio.GrabarEditar(oCategoria);
            }

            return respuesta;
        }

        public bool Habilitar(int codigoCategoria)
        {
            bool respuesta = false;
            using (ICategoriaRepositorio oRepositorio = new CategoriaRepositorio())
            {
                respuesta = oRepositorio.Habilitar(codigoCategoria);
            }

            return respuesta;
        }

        public IEnumerable<MKFCategoriaResponse> TraerTodos()
        {
            IEnumerable<MKFCategoriaResponse> oLista = null;
            using (ICategoriaRepositorio oRepositorio = new CategoriaRepositorio())
            {
                oLista = oRepositorio.TraerTodos();
            }

            return oLista;
        }

        public MKFCategoriaResponse TraerUno(int codigoCategoria)
        {
            MKFCategoriaResponse oObjeto = null;
            using (ICategoriaRepositorio oRepositorio = new CategoriaRepositorio())
            {
                oObjeto = oRepositorio.TraerUno(codigoCategoria);
            }

            return oObjeto;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
