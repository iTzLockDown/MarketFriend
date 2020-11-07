using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Microsoft.Extensions.Configuration;
namespace MarketFriend.WS.Repositorio.Contrato
{
    public class dbContext
    {
        #region Variables y Parametros

        private static IConfiguration _configuration;
        
        #endregion

        #region Constructor
        public dbContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        #endregion


        #region Metodos

        public static string ADMGENESYS()
        {
            string ambiente = "DESARROLLO";
            string cadenaConexion =string.Empty; 

            switch (ambiente)
            {
                case "DESARROLLO":
                    cadenaConexion = "Data Source=.;Initial Catalog=ADMGENESYS;Integrated Security=True";
                    break;
                case "PRODUCCION":
                    cadenaConexion = _configuration.GetSection("cnSeguridadProdDB").Value;
                    break;
                default:
                    break;
            }

            return cadenaConexion;
        }

        #endregion

        
    }
}
