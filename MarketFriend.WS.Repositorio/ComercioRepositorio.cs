using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using MarketFriend.WS.Bloque.SqlServer;
using MarketFriend.WS.Modelo.Response;
using MarketFriend.WS.Repositorio.Contrato;
using MarketFriend.WS.Repositorio.Contrato.SqlServer;
using MarketFriend.WS.Bloque.SqlServer.Funciones;
using MarketFriend.WS.Bloque.SqlServer.Clases;
using MarketFriend.WS.Modelo.Request;

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

        public IEnumerable<MKFComercioResponse> TraerProximo(float GpsLatitud, float GpsLongitud)
        {
            IEnumerable<MKFComercioResponse> oLista = null;
            string sp = StoredProcedure.USP_COMERCIO_LISTA_PROXIMO;
            List<SqlParameterItem> parametros = new List<SqlParameterItem>();
            parametros.Add(new SqlParameterItem("@x_nGpsLatitu", SqlDbType.Float, GpsLatitud));
            parametros.Add(new SqlParameterItem("@x_nGpsLongit", SqlDbType.Float, GpsLongitud));
            using (SqlHelperWS oSqlHelperWS = new SqlHelperWS(dbContext.ADMGENESYS()))
            {
                using (SqlDataReader reader = oSqlHelperWS.ExecuteReader(sp))
                {
                    oLista = reader.Select(DesdeDataReaderTraerProximo).ToList();
                }
            }
            return oLista;
        }

        public MKFComercioResponse TraerUno(int codigoComercio)
        {
            MKFComercioResponse oObjeto = null;
            string sp = StoredProcedure.USP_COMERCIO_TRAEUNO;
            List<SqlParameterItem> parametros = new List<SqlParameterItem>();
            parametros.Add(new SqlParameterItem("@x_nCodigoCom", SqlDbType.Int, codigoComercio));
            using (SqlHelperWS db = new SqlHelperWS(dbContext.ADMGENESYS()))
            {
                using (SqlDataReader reader = db.ExecuteReader(sp, parametros))
                {
                    oObjeto = reader.Select(DesdeDataReader).First();
                }
            }

            return oObjeto;
        }
        public MKFComercioResponse TraerNombre(string nombreComercio)
        {
            MKFComercioResponse oObjeto = null;
            string sp = StoredProcedure.USP_COMERCIO_LISTANOMBRE;
            List<SqlParameterItem> parametros = new List<SqlParameterItem>();
            parametros.Add(new SqlParameterItem("@x_nNombreCom", SqlDbType.VarChar, nombreComercio));
            using (SqlHelperWS db = new SqlHelperWS(dbContext.ADMGENESYS()))
            {
                using (SqlDataReader reader = db.ExecuteReader(sp, parametros))
                {
                    oObjeto = reader.Select(DesdeDataReaderCategoria).First();
                }
            }

            return oObjeto;
        }
        public bool GrabarEditar(MKFComercioRequest oComercio)
        {
            bool respuesta = false;
            string sp = StoredProcedure.USP_COMERCIO_CREATE_UPDATE;
            List<SqlParameterItem> parametros = new List<SqlParameterItem>();
            parametros.Add(new SqlParameterItem("@x_nCodigoCom", SqlDbType.Int, oComercio.Codigo));
            parametros.Add(new SqlParameterItem("@x_cNombreCom", SqlDbType.VarChar, oComercio.Nombre));
            parametros.Add(new SqlParameterItem("@x_cDirComerc", SqlDbType.VarChar, oComercio.Direccion));
            parametros.Add(new SqlParameterItem("@x_cTelefoCom", SqlDbType.VarChar, oComercio.Telefono));
            parametros.Add(new SqlParameterItem("@x_cImagenCom", SqlDbType.VarChar, oComercio.Imagen));
            parametros.Add(new SqlParameterItem("@x_nCodCatCom", SqlDbType.Int, oComercio.CodigoCategoria));
            parametros.Add(new SqlParameterItem("@x_nCodigoUsu", SqlDbType.Int, oComercio.CodigoUsuario));
            parametros.Add(new SqlParameterItem("@x_nCodUsuReg", SqlDbType.Int, oComercio.CodigoUsuarioRegistra));
            parametros.Add(new SqlParameterItem("@x_nGpsLatitu", SqlDbType.Float, oComercio.GpsLatitud));
            parametros.Add(new SqlParameterItem("@x_nGpsLongit", SqlDbType.Float, oComercio.GpsLongitud));
            using (SqlHelperWS db = new SqlHelperWS(dbContext.ADMGENESYS()))
            {
                respuesta = db.ExecuteNonQuery(sp, parametros);
            }
            return respuesta;
        }

        public bool Eliminar(int codigoComercio)
        {
            bool respuesta = false;
            string sp = StoredProcedure.USP_COMERCIO_ELIMINA;
            List<SqlParameterItem> parametros = new List<SqlParameterItem>();
            parametros.Add(new SqlParameterItem("@x_nCodigoCom", SqlDbType.Int, codigoComercio));
            using (SqlHelperWS db = new SqlHelperWS(dbContext.ADMGENESYS()))
            {
                respuesta = db.ExecuteNonQuery(sp, parametros);
            }
            return respuesta;
        }
        public bool Habilitar(int codigoComercio)
        {
            bool respuesta = false;
            string sp = StoredProcedure.USP_COMERCIO_HABILITA;
            List<SqlParameterItem> parametros = new List<SqlParameterItem>();
            parametros.Add(new SqlParameterItem("@x_nCodigoCom", SqlDbType.Int, codigoComercio));
            using (SqlHelperWS db = new SqlHelperWS(dbContext.ADMGENESYS()))
            {
                respuesta = db.ExecuteNonQuery(sp, parametros);
            }
            return respuesta;
        }

        public IEnumerable<MKFComercioResponse> TraerCategoria(int codigoCategoria)
        {
            IEnumerable<MKFComercioResponse> oLista = null;
            string sp = StoredProcedure.USP_COMERCIO_LISTACATEGORIA;
            List<SqlParameterItem> parametros = new List<SqlParameterItem>();
            parametros.Add(new SqlParameterItem("@x_nCodCatCom", SqlDbType.Int, codigoCategoria));
            using (SqlHelperWS db = new SqlHelperWS(dbContext.ADMGENESYS()))
            {
                using (SqlDataReader reader = db.ExecuteReader(sp, parametros))
                {
                    oLista = reader.Select(DesdeDataReaderCategoria).ToList();
                }
            }

            return oLista;
        }
        public MKFComercioResponse TraerMejorCalificado(float gpsLatitud, float gpsLongitud)
        {
            MKFComercioResponse oObjeto = null;
            string sp = StoredProcedure.USP_COMERCIO_TRAEUNO_PROXIMO;
            List<SqlParameterItem> parametros = new List<SqlParameterItem>();
            parametros.Add(new SqlParameterItem("@x_nGpsLatitu", SqlDbType.Float, gpsLatitud));
            parametros.Add(new SqlParameterItem("@x_nGpsLongit", SqlDbType.Float, gpsLongitud));
            using (SqlHelperWS db = new SqlHelperWS(dbContext.ADMGENESYS()))
            {
                using (SqlDataReader reader = db.ExecuteReader(sp, parametros))
                {
                    oObjeto = reader.Select(DesdeDataReaderTraerProximo).First();
                }
            }

            return oObjeto;

        }

        public IEnumerable<MKFMensajeResponse> CalificaComercio(MKFClasificacionRequest oCalifica)
        {
            IEnumerable<MKFMensajeResponse> oLista = null;
            string sp = StoredProcedure.USP_CLASIFICACION_CREA;
            List<SqlParameterItem> parametros = new List<SqlParameterItem>();
            parametros.Add(new SqlParameterItem("@x_nTieAteCom", SqlDbType.Int, oCalifica.Tiempo));
            parametros.Add(new SqlParameterItem("@x_nPreProCom", SqlDbType.Int, oCalifica.Precio));
            parametros.Add(new SqlParameterItem("@x_nCalAteCom", SqlDbType.Int, oCalifica.Calidad));
            parametros.Add(new SqlParameterItem("@x_cComAteCom", SqlDbType.VarChar, oCalifica.Comentario));
            parametros.Add(new SqlParameterItem("@x_nCodigoCom", SqlDbType.Int, oCalifica.CodigoComercio));
            parametros.Add(new SqlParameterItem("@x_nCodigoUsu", SqlDbType.Int, oCalifica.CodigoUsuario));
            using (SqlHelperWS db = new SqlHelperWS(dbContext.ADMGENESYS()))
            {
                using (SqlDataReader reader = db.ExecuteReader(sp, parametros))
                {
                    oLista = reader.Select(DesdeDataReaderMensaje).ToList();
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

        public MKFComercioResponse DesdeDataReaderCategoria(IDataReader reader)
        {
            return new MKFComercioResponse()
            {
                Categoria = reader.GetValue(0).ToString().Trim(),
                Nombre = reader.GetValue(1).ToString().Trim(),
                Direccion = reader.GetValue(2).ToString().Trim(),
                Telefono = reader.GetValue(3).ToString().Trim(),
                Imagen = reader.GetValue(4).ToString().Trim(),
                PrecioProducto = reader.GetValue(5).ToString().Trim(),
                CalidadProducto = reader.GetValue(6).ToString().Trim(),
                TiempoAtencion = reader.GetValue(7).ToString().Trim(),
            };
        }

        public MKFComercioResponse DesdeDataReaderTraerProximo(IDataReader reader)
        {
            return new MKFComercioResponse()
            {
                Categoria= reader.GetValue(0).ToString().Trim(),
                Codigo = reader.GetValue(1).ToString().Trim(),
                Nombre = reader.GetValue(2).ToString().Trim(),
                Direccion = reader.GetValue(3).ToString().Trim(),
                Telefono = reader.GetValue(4).ToString().Trim(),
                Imagen = reader.GetValue(5).ToString().Trim(),
                CalidadProducto = reader.GetValue(6).ToString().Trim(),
                Distancia = reader.GetValue(7).ToString().Trim()

            };
        }

        public MKFMensajeResponse DesdeDataReaderMensaje(IDataReader reader)
        {
            return new MKFMensajeResponse()
            {
                Mensaje = reader.GetValue(0).ToString(),
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
