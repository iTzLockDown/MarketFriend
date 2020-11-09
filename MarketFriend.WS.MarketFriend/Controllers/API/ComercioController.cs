using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MarketFriend.WS.Dominio;
using MarketFriend.WS.Dominio.Contrato;
using MarketFriend.WS.Modelo.Response;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MarketFriend.WS.MarketFriend.Controllers.API
{
    [Route(Ruta.UriComercio.Prefijo)]
    [ApiController]
    [Authorize]
    public class ComercioController : Controller
    {
        private readonly ILogger<ComercioController> _logger;

        public ComercioController(ILogger<ComercioController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route(Ruta.UriComercio.ListaComercio)]
        public IActionResult Index()
        {
            List<MKFComercioResponse> oLista = null;
            using (IComercioDominio oDominio = new ComercioDominio())
            {
                oLista = oDominio.TraerTodos().ToList();
            }
            if (oLista == null) return NotFound();

            return Ok(oLista);
        }
        [HttpGet]
        [Route("comtemplando")]
        public string Index2()
        {
            return "desde el token";
        }
    }
}
