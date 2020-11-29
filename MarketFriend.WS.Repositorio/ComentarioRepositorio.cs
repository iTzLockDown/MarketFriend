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
using MarketFriend.WS.Repositorio.Contrato.SqlServer;

namespace MarketFriend.WS.Repositorio.Contrato
{
    public class ComentarioRepositorio : IComentarioRepositorio
    {
        public IEnumerable<MKFComentarioResponse> TraerTodos(int codigoComercio)
        {
            IEnumerable<MKFComentarioResponse> oLista = null;
            string sp = StoredProcedure.USP_COMENTARIO_LISTA_COMERCIO;
            List<SqlParameterItem> parametros = new List<SqlParameterItem>();
            parametros.Add(new SqlParameterItem("@x_nCodComApp", SqlDbType.Int, codigoComercio));
            using (SqlHelperWS db = new SqlHelperWS(dbContext.ADMGENESYS()))
            {
                using (SqlDataReader reader = db.ExecuteReader(sp, parametros))
                {
                    oLista = reader.Select(DesdeDataReader).ToList();
                }
            }
            return oLista;
        }

        public MKFComentarioResponse DesdeDataReader(IDataReader reader)
        {
            return new MKFComentarioResponse()
            {
                Comentario = reader.GetValue(0).ToString(),
                Usuario = reader.GetValue(1).ToString(),
                Fecha = DateTime.Parse(reader.GetDateTime(2).ToString()),

            };
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
