using System;
using System.Collections.Generic;
using System.Text;

namespace MarketFriend.WS.Modelo.Response
{
    /// <summary>
    /// SP: AMD_LisComPro_SP
    /// </summary>
    public class MKFComercioProximoResponse
    {
        public string Categoria { get; set; }               //Categoria
        public string Codigo { get; set; }                  //Codigo
        public string Nombre { get; set; }                  //Nombre
        public string Direccion { get; set; }               //Direccion
        public string Telefono { get; set; }                //Telefono
        public string Imagen { get; set; }                  //Imagen
        public string CalidadAtencion { get; set; }         //CalidadAtencion
        public string Distancia { get; set; }               //Distancia

    }
}
