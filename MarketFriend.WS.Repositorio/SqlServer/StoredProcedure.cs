using System;
using System.Collections.Generic;
using System.Text;

namespace MarketFriend.WS.Repositorio.Contrato.SqlServer
{
    public class StoredProcedure
    {
        #region Usuario
        public const string USP_USUARIO_AUTH = "AMD_AutUseApp_SP";

        public static string USP_USUARIO_DESBLOQUEA = "AMD_DesUseApp_SP";
        #endregion
        #region Comercios

        public const string USP_COMERCIO_LISTA = "AMD_LisComApp_SP";
        public const string USP_COMERCIO_LISTA_PROXIMO = "AMD_LisComPro_SP";
        public const string USP_COMERCIO_CREATE_UPDATE = "ADM_CreUpdCom_SP";
        public const string USP_COMERCIO_TRAEUNO = "AMD_BusComIde_SP";
        public const string USP_COMERCIO_ELIMINA = "ADM_DelLogCom_SP";
        public const string USP_COMERCIO_HABILITA = "ADM_ActLogCom_SP";
        public const string USP_COMERCIO_LISTACATEGORIA = "AMD_BusComCat_SP";
        public const string USP_COMERCIO_LISTANOMBRE = "AMD_BusComNom_SP";
        public const string USP_COMERCIO_TRAEUNO_PROXIMO = "ADM_BusComPro";
        public const string USP_COMERCIO_TRAE_IMAGEN = "ADM_ExtImgCom_SP";

        public const string USP_COMERCIO_SUBIR_IMAGEN = "ADM_UpdImgCom_SP";
        #endregion


        #region Categoria
        public const string USP_CATEGORIACOMERCIO_LISTA = "AMD_LisCatCom_SP";
        public const string USP_CATEGORIACOMERCIO_CREATE_UPDATE = "ADM_CreUpdCatCom_SP";
        public const string USP_CATEGORIACOMERCIO_TRAEUNO = "AMD_BusCatCom_SP";
        public const string USP_CATEGORIACOMERCIO_ELIMINA = "ADM_DelLogCatCom_SP";
        public const string USP_CATEGORIACOMERCIO_HABILITA = "ADM_ActLogCatCom_SP";
        #endregion

        #region Clasificacion

        public const string USP_CLASIFICACION_CREA = "ADM_CreClaCom_SP";

        #endregion

        #region Comentario

        public const string USP_COMENTARIO_LISTA_COMERCIO = "AMD_LisComCom_SP";

        #endregion





    }
}
