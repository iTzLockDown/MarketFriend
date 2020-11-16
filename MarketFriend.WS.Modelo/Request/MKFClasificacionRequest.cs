using System;
using System.Collections.Generic;
using System.Text;

namespace MarketFriend.WS.Modelo.Request
{
    /// <summary>
    /// SP: ADM_CreClaCom_SP
    /// </summary>
    public class MKFClasificacionRequest
    {
        public int Tiempo { get; set; }             //@x_nTieAteCom
        public int Precio { get; set; }             //@x_nPreProCom
        public int Calidad { get; set; }            //@x_nCalAteCom
        public string Comentario { get; set; }      //@x_cComAteCom
        public int CodigoComercio { get; set; }     //@x_nCodigoCom  
        public int CodigoUsuario { get; set; }      //@x_nCodigoUsu
    }
}
