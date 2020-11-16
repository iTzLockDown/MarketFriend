using System;
using System.Collections.Generic;
using System.Text;

namespace MarketFriend.WS.Modelo.Response
{
    /// <summary>
    /// SP: AMD_LisCatCom_SP
    /// </summary>
    public class MKFCategoriaResponse
    {
        public string Categoria { get; set; }       //Categoria
        public string Descripcion { get; set; }     //Descripcion
        public string Estado { get; set; }          //Estado
    }
}
