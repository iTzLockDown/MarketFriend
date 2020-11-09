using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using MarketFriend.WS.Bloque.SqlServer;
using MarketFriend.WS.Bloque.SqlServer.Clases;
using MarketFriend.WS.Bloque.SqlServer.Funciones;
using MarketFriend.WS.Modelo.Response;
using MarketFriend.WS.Repositorio.Contrato;
using MarketFriend.WS.Repositorio.Contrato.Seguridad;
using MarketFriend.WS.Repositorio.Contrato.SqlServer;

namespace MarketFriend.WS.Repositorio.Seguridad
{
    public class LoginRepositorio:ILoginRepositorio
    {
        public bool Autentificacion(string usuario, string password)
        {
            bool respuesta = false;
            MKFUsuarioReponse oUsuario = null;
            string sp = StoredProcedure.USP_USUARIO_AUTH;
            List<SqlParameterItem> parametros = new List<SqlParameterItem>();
            parametros.Add(new SqlParameterItem("@x_cCorElectr", SqlDbType.VarChar, usuario));
            parametros.Add(new SqlParameterItem("@x_cClaSecret", SqlDbType.VarChar, password));
            
            using (SqlHelperWS oSqlHelperWS = new SqlHelperWS(dbContext.ADMGENESYS()))
            {
                using (SqlDataReader reader = oSqlHelperWS.ExecuteReader(sp, parametros))
                {
                    oUsuario = reader.Select(DesdeDataReader).FirstOrDefault();
                }
            }

            respuesta = oUsuario != null ? true:false;
            return respuesta;

        }

        public MKFUsuarioReponse TraerUsuario(string usuario, string password)
        {
            MKFUsuarioReponse oUsuario = null;
            string sp = StoredProcedure.USP_USUARIO_AUTH;
            List<SqlParameterItem> parametros = new List<SqlParameterItem>();
            parametros.Add(new SqlParameterItem("@x_cCorElectr", SqlDbType.VarChar, usuario));
            parametros.Add(new SqlParameterItem("@x_cClaSecret", SqlDbType.VarChar, password));

            using (SqlHelperWS oSqlHelperWS = new SqlHelperWS(dbContext.ADMGENESYS()))
            {
                using (SqlDataReader reader = oSqlHelperWS.ExecuteReader(sp, parametros))
                {
                    oUsuario = reader.Select<MKFUsuarioReponse>(DesdeDataReader).First();
                }
            }
            return oUsuario;
        }

        public MKFUsuarioReponse DesdeDataReader(IDataReader reader)
        {
            return new MKFUsuarioReponse()
            {
                Codigo = reader.GetValue(0).ToString(),
                Usuario = reader.GetValue(1).ToString(),
                CodigEstadoo = reader.GetValue(2).ToString(),

            };
        }
        public bool CambiarContrasenia(string usuario, string password, string nuevoPassword)
        {
            return false;
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
