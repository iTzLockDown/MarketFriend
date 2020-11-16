using System;
using System.Collections.Generic;
using System.Text;

namespace MarketFriend.WS.Modelo.Request
{
    /// <summary>
    /// SP:ADM_CreUpdCatCom_SP
    /// </summary>
    public class MKFCategoriaRequest
    {
        public int Codigo { get; set; }                 //@x_nCodCatCom
        public string Nombre { get; set; }              //@x_cNomCatCom
        public string Descripcion { get; set; }         //@x_cDesCatCom
        public int CodigoUsuario { get; set; }          //@x_nCodUsuReg
    }
}
