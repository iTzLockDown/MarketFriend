using System;
using System.Collections.Generic;
using System.Text;

namespace MarketFriend.WS.Repositorio.Contrato.SqlServer
{
    public class StoredProcedure
    {
        #region Usuario
        public const string USP_USUARIO_AUTH = "AMD_AutUseApp_SP";

        public static String USP_USUARIO_DESBLOQUEA = "AMD_DesUseApp_SP";
        #endregion
        #region Comercios

        public const string USP_COMERCIO_LISTA = "AMD_LisComApp_SP";

        #endregion

    }
}
