using System;
using System.Collections.Generic;
using System.Text;

namespace MarketFriend.WS.Modelo.Response
{
    /// <summary>
    /// SP: AMD_LisComApp_SP || ADM_BusComPro
    /// </summary>
    public class MKFComercioResponse
    {
        public string Categoria { get; set; }           //Categoria
        public string Codigo { get; set; }              //Codigo
        public string Nombre { get; set; }              //Nombre
        public string Direccion { get; set; }           //Direccion
        public string Telefono { get; set; }            //Telefono
        public string Imagen { get; set; }              //Imagen
        public string PrecioProducto { get; set; }      //PrecioProducto
        public string CalidadProducto { get; set; }     //CalidadProducto
        public string TiempoAtencion { get; set; }      //TiempoAtencion
        public string Latitud { get; set; }             //Latitud
        public string Longitud { get; set; }            //Longitud

        public string Distancia { get; set; }           //Distancia
    }
}
