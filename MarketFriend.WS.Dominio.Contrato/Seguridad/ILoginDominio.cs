using System;
using System.Collections.Generic;
using System.Text;
using MarketFriend.WS.Modelo.Response;

namespace MarketFriend.WS.Dominio.Contrato.Seguridad
{
    public interface ILoginDominio:IDisposable
    {
        bool Autentificacion(string usuario, string password);
        bool CambiarContrasenia(string usuario, string password, string nuevoPassword);
        MKFUsuarioReponse TraerUsuario(string usuario, string password);
    }
}
