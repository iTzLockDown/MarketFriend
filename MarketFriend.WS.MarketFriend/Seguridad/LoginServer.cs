using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using MarketFriend.WS.Dominio.Contrato.Seguridad;
using MarketFriend.WS.Dominio.Seguridad;
using Newtonsoft.Json;

namespace MarketFriend.WS.Bloque.SqlServer.Seguridad
{
    public sealed class LoginServer
    {
        #region Variables y Propiedades

        private const int LOGON32_LOGON_INTERACTIVE = 2;
        private const int LOGON32_PROVIDER_DEFAULT = 0;
        private const uint NERR_Success = 0;
        private const uint NERR_UserNotFound = 2221;
        private const uint ERROR_INVALID_PASSWORD = 86;
        private const uint NERR_PasswordTooShort = 2245;
        private IntPtr token = IntPtr.Zero;

        public string Usuario { get; set; } //Usuario Windows
        public string Contrasenia { get; set; } //Contraseña Windows

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string NuevaContrasenia { get; set; } //Nueva Contraseña

        #endregion

        #region Métodos


        public bool ValidaInicioSesion()
        {
            bool respuesta = false;
            using (ILoginDominio oDominio = new LoginDominio())
            {
                respuesta = oDominio.Autentificacion(Usuario, Contrasenia);
            }

            return respuesta;
        }

        //public bool CambiarContraseña(out string mensaje)
        //{
           
        //    switch (resultado)
        //    {
        //        case NERR_Success:
        //            mensaje = "Cambio de contraseña: Correcto";
        //            return true;

        //        case NERR_UserNotFound:
        //            mensaje = "El usuario es incorrecto";
        //            return false;

        //        case ERROR_INVALID_PASSWORD:
        //            mensaje = "La contraseña actual es incorrecta";
        //            return false;

        //        case NERR_PasswordTooShort:
        //            mensaje = "La contraseña no cumple con las políticas de contraseñas\r\n" +
        //                      "Compruebe la longitud mínima, complejidad y requisitos del historial";
        //            return false;

        //        default:
        //            mensaje = "Se produjo un error de acceso, dominio u otro no contemplado";
        //            return false;
        //    }
        //}

        #endregion
    }
}
