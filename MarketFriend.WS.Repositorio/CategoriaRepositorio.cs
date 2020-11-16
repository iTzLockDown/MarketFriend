using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Numerics;
using System.Text;
using MarketFriend.WS.Bloque.SqlServer;
using MarketFriend.WS.Bloque.SqlServer.Clases;
using MarketFriend.WS.Bloque.SqlServer.Funciones;
using MarketFriend.WS.Modelo.Request;
using MarketFriend.WS.Modelo.Response;
using MarketFriend.WS.Repositorio.Contrato.SqlServer;

namespace MarketFriend.WS.Repositorio.Contrato
{
    public class CategoriaRepositorio_: ICategoriaRepositorio
    {
        public IEnumerable<MKFCategoriaResponse> TraerTodos()
        {
            IEnumerable<MKFCategoriaResponse> oLista = null;
            string sp = StoredProcedure.USP_CATEGORIACOMERCIO_LISTA;
            using (SqlHelperWS db = new SqlHelperWS(dbContext.ADMGENESYS()))
            {
                using (SqlDataReader reader = db.ExecuteReader(sp))
                {
                    oLista = reader.Select(DesdeDataReader).ToList();
                }
            }

            return oLista;
        }

        public bool GrabarEditar(MKFCategoriaRequest oCategoria)
        {
            bool respuesta = false;
            string sp = StoredProcedure.USP_CATEGORIACOMERCIO_CREATE_UPDATE;
            List<SqlParameterItem> parametros = new List<SqlParameterItem>();
            parametros.Add(new SqlParameterItem("@x_nCodCatCom", SqlDbType.Int, oCategoria.Codigo));
            parametros.Add(new SqlParameterItem("@x_cNomCatCom", SqlDbType.VarChar, oCategoria.Nombre));
            parametros.Add(new SqlParameterItem("@x_cDesCatCom", SqlDbType.VarChar, oCategoria.Descripcion));
            parametros.Add(new SqlParameterItem("@x_nCodUsuReg", SqlDbType.Int, oCategoria.CodigoUsuario));
            using (SqlHelperWS db = new SqlHelperWS(dbContext.ADMGENESYS()))
            {
                respuesta = db.ExecuteNonQuery(sp);
            }

            return respuesta;
        }
        public  MKFCategoriaResponse TraerUno(int codigoCategoria)
        {
            MKFCategoriaResponse oObjeto = null;
            string sp = StoredProcedure.USP_CATEGORIACOMERCIO_TRAEUNO;
            List<SqlParameterItem> parametros = new List<SqlParameterItem>();
            parametros.Add(new SqlParameterItem("@x_nCodCatCom", SqlDbType.BigInt, codigoCategoria));
            using (SqlHelperWS db = new SqlHelperWS(dbContext.ADMGENESYS()))
            {
                using (SqlDataReader reader = db.ExecuteReader(sp, parametros))
                {
                    oObjeto = reader.Select(DesdeDataReader).First();
                }
                
            }

            return oObjeto;
        }
        public bool Eliminar(int codigoCategoria)
        {
            bool respuesta = false;
            string sp = StoredProcedure.USP_CATEGORIACOMERCIO_ELIMINA;
            List<SqlParameterItem> parametros = new List<SqlParameterItem>();
            parametros.Add(new SqlParameterItem("@x_nCodCatCom", SqlDbType.BigInt, codigoCategoria));
            using (SqlHelperWS db = new SqlHelperWS(dbContext.ADMGENESYS()))
            {
                respuesta = db.ExecuteNonQuery(sp, parametros);
            }

            return respuesta;
        }

        public bool Habilitar(int codigoCategoria)
        {
            bool respuesta = false;
            string sp = StoredProcedure.USP_CATEGORIACOMERCIO_HABILITA;
            List<SqlParameterItem> parametros = new List<SqlParameterItem>();
            parametros.Add(new SqlParameterItem("@x_nCodCatCom", SqlDbType.BigInt, codigoCategoria));
            using (SqlHelperWS db = new SqlHelperWS(dbContext.ADMGENESYS()))
            {
                respuesta = db.ExecuteNonQuery(sp, parametros);
            }

            return respuesta;
        }

        public MKFCategoriaResponse DesdeDataReader(IDataReader reader)
        {
            return new MKFCategoriaResponse()
            {
                Categoria = reader.GetValue(0).ToString().Trim(),
                Descripcion = reader.GetValue(1).ToString().Trim(),
                Estado = reader.GetValue(2).ToString().Trim(),
            };
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
