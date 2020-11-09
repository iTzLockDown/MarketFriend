using System;
using System.Collections.Generic;
using System.Text;
using MarketFriend.WS.Modelo.Response;

namespace MarketFriend.WS.Repositorio.Contrato.Seguridad
{
    public interface ILoginRepositorio:IDisposable
    {
        bool Autentificacion(string usuario, string password);
        MKFUsuarioReponse TraerUsuario(string usuario, string password);
        bool CambiarContrasenia(string usuario, string password, string nuevoPassword);
    }
}
