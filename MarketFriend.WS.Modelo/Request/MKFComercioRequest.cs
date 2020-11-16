using System;
using System.Collections.Generic;
using System.Text;

namespace MarketFriend.WS.Modelo.Request
{
    /// <summary>
    /// sp: ADM_CreUpdCom_SP
    /// </summary>
    public class MKFComercioRequest
    {
        public int Codigo { get; set; } //@x_nCodigoCom
        public string Nombre { get; set; } //@x_cNombreCom
        public string Direccion{ get; set; } //@x_cDirComerc
        public string Telefono { get; set; } //@x_cTelefoCom
        public string Imagen { get; set; } //@x_cImagenCom
        public int CodigoCategoria { get; set; } //@x_nCodCatCom
        public int CodigoUsuario { get; set; } //@x_nCodigoUsu
        public int CodigoUsuarioRegistra { get; set; } //@x_nCodUsuReg
        public float GpsLatitud { get; set; } //@x_nGpsLatitu
        public float GpsLongitud { get; set; } //@x_nGpsLongit

    }





}
