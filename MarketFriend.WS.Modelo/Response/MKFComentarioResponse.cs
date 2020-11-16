using System;
using System.Collections.Generic;
using System.Text;

namespace MarketFriend.WS.Modelo.Response
{
    /// <summary>
    /// SP: AMD_LisComCom_SP
    /// </summary>
    public class MKFComentarioResponse
    {
        public string  Comentario { get; set; }//Comentario
        public string Usuario{ get; set; }//Usuario
        public DateTime Fecha { get; set; }//Fecha
    }
}
