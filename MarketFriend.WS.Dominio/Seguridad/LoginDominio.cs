using System;
using System.Collections.Generic;
using System.Text;
using MarketFriend.WS.Dominio.Contrato.Seguridad;
using MarketFriend.WS.Modelo.Response;
using MarketFriend.WS.Repositorio.Contrato.Seguridad;
using MarketFriend.WS.Repositorio.Seguridad;

namespace MarketFriend.WS.Dominio.Seguridad
{
    public class LoginDominio:ILoginDominio
    {
        public bool Autentificacion(string usuario, string password)
        {
            bool respuesta = false;
            using (ILoginRepositorio oRepositorio = new LoginRepositorio())
            {
                respuesta = oRepositorio.Autentificacion(usuario, password);
            }

            return respuesta;
        }

        public MKFUsuarioReponse TraerUsuario(string usuario, string password)
        {
            MKFUsuarioReponse oUsuario = null;
            using (ILoginRepositorio oRepositorio = new LoginRepositorio())
            {
                oUsuario = oRepositorio.TraerUsuario(usuario, password);
            }

            return oUsuario;
        }
        public bool CambiarContrasenia(string usuario, string password, string nuevoPassword)
        {
            bool respuesta = false;
            using (ILoginRepositorio oRepositorio = new LoginRepositorio())
            {
                respuesta = oRepositorio.CambiarContrasenia(usuario, password, nuevoPassword);
            }

            return respuesta;
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
