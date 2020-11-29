using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MarketFriend.WS.Dominio;
using MarketFriend.WS.Dominio.Contrato;
using MarketFriend.WS.Modelo.Response;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Logging;

namespace MarketFriend.WS.MarketFriend.Controllers.API
{
    [Route(Ruta.UriComentario.Prefijo)]
    [ApiController]
    [Authorize]
    public class ComentarioController : Controller
    {
        private readonly ILogger<ComentarioController> _logger;

        public ComentarioController(ILogger<ComentarioController> logger)
        {
            _logger = logger;
        }


        [HttpGet]
        [Route(Ruta.UriComentario.Comentario)]
        public IActionResult TraerTodos(int codigoComercio)
        {
            IEnumerable<MKFComentarioResponse> oLista = null;
            using (IComentarioDominio oDominio = new ComentarioDominio())
            {
                oLista = oDominio.TraerTodos(codigoComercio);
            }
            if (oLista == null) return NotFound();

            return Ok(oLista);
        }

    }
}
