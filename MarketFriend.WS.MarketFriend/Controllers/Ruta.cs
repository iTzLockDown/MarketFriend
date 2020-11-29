using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarketFriend.WS.MarketFriend.Controllers
{
    public class Ruta
    {
        
        public class UriLogin
        {
            public const string Prefijo = "api/login";
            public const string Autentificacion = "autentificacion";
        }
        public class UriComercio
        {
            public const string Prefijo = "api/comercio";
            public const string TraerTodos = "listar";
            public const string TraerProximo = "listarproximo";
            public const string TraerUno = "listauno";
            public const string TraerNombre = "listanombre";
            public const string GrabarEditar = "grabareditar";
            public const string Eliminar = "eliminar";
            public const string Habilita = "habilita";
            public const string TraerCategoria = "traercategoria";
            public const string MejorCalificado = "mejorcalificado";
            public const string Clasificacion = "clasificacion";


        }

        public class UriCategoria
        {
            public const string Prefijo = "api/categoria";

            public const string Lista = "lista";
            public const string GrabarEditar = "grabareditar";
            public const string ListaUno = "listaruno";
            public const string Elimina= "elimina";
            public const string Habilita= "habilita";
        }
        public class UriComentario
        {
            public const string Prefijo = "api/comentario";
            public const string Comentario = "comentario";
        }


    }
}
