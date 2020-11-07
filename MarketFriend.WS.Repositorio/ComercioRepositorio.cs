using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using MarketFriend.WS.Modelo.Response;
using MarketFriend.WS.Repositorio.Contrato;
using MarketFriend.WS.Repositorio.Contrato.SqlServer;
using MarketFriend.WS.Bloque.SqlServer.Funciones;
using MarketFriend.WS.Bloque.SqlServer.Clases;

namespace MarketFriend.WS.Repositorio
{
    public class ComercioRepositorio : IComercioRepositorio
    {
        #region Metodos
        public IEnumerable<MKFComercioResponse> TraerTodos()
        {
            IEnumerable<MKFComercioResponse> oLista = null;
            string sp = StoredProcedure.USP_COMERCIO_LISTA;
            using (SqlHelperWS oSqlHelperWS = new SqlHelperWS(dbContext.ADMGENESYS()))
            {
                using (SqlDataReader reader = oSqlHelperWS.ExecuteReader(sp))
                {
                    oLista = reader.Select(DesdeDataReader).ToList();
                }
            }
            return oLista;
        }
        #endregion

        #region DataReader
        public MKFComercioResponse DesdeDataReader(IDataReader reader)
        {
            return new MKFComercioResponse()
            {
                Categoria = reader.GetValue(0).ToString().Trim(),
                Codigo = reader.GetValue(1).ToString().Trim(),
                Nombre = reader.GetValue(2).ToString().Trim(),
                Direccion = reader.GetValue(3).ToString().Trim(),
                Telefono = reader.GetValue(4).ToString().Trim(),
                Imagen = reader.GetValue(5).ToString().Trim(),
                PrecioProducto = reader.GetValue(6).ToString().Trim(),
                CalidadProducto = reader.GetValue(7).ToString().Trim(),
                TiempoAtencion = reader.GetValue(8).ToString().Trim(),
                Latitud = reader.GetValue(9).ToString().Trim(),
                Longitud = reader.GetValue(10).ToString().Trim(),
            };
        }
        #endregion


        #region Dispose
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
        #endregion

  
    }
}
