using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MarketFriend.WS.Dominio;
using MarketFriend.WS.Dominio.Contrato;
using MarketFriend.WS.Modelo.Request;
using MarketFriend.WS.Modelo.Response;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Logging;

namespace MarketFriend.WS.MarketFriend.Controllers.API
{
    [Route(Ruta.UriCategoria.Prefijo)]
    [ApiController]
    [Authorize]
    public class CategoriaController : Controller
    {
        private readonly ILogger<CategoriaController> _logger;

        public CategoriaController(ILogger<CategoriaController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route(Ruta.UriCategoria.Lista)]
        public IActionResult TraerTodos()
        {
            List<MKFCategoriaResponse> oLista = null;
            using (ICategoriaDominio oDominio = new CategoriaDominio())
            {
                oLista = oDominio.TraerTodos().ToList();
            }
            if (oLista == null) return NotFound();

            return Ok(oLista);
        }

        [HttpGet]
        [Route(Ruta.UriCategoria.ListaUno)]
        public IActionResult TraerUno(int codigoCategoria)
        {
            MKFCategoriaResponse oObjeto = null;
            using (ICategoriaDominio oDominio = new CategoriaDominio())
            {
                oObjeto = oDominio.TraerUno(codigoCategoria);
            }
            if (oObjeto == null) return NotFound();

            return Ok(oObjeto);
        }

        [HttpPost]
        [Route(Ruta.UriCategoria.GrabarEditar)]
        public IActionResult GrabarEditar([FromBody] MKFCategoriaRequest oCategoria)
        {
            bool respuesta = false;
            using (ICategoriaDominio oDominio = new CategoriaDominio())
            {
                respuesta = oDominio.GrabarEditar(oCategoria);
            }
            if (respuesta == null) return NotFound();

            return Ok(respuesta);
        }

        [HttpDelete]
        [Route(Ruta.UriCategoria.Elimina)]
        public IActionResult Elimina(int codigoCategoria)
        {
            bool respuesta = false;
            using (ICategoriaDominio oDominio = new CategoriaDominio())
            {
                respuesta = oDominio.Eliminar(codigoCategoria);
            }
            if (respuesta == null) return NotFound();

            return Ok(respuesta);
        }

        [HttpPut]
        [Route(Ruta.UriCategoria.Habilita)]
        public IActionResult Habilita(int codigoCategoria)
        {
            bool respuesta = false;
            using (ICategoriaDominio oDominio = new CategoriaDominio())
            {
                respuesta = oDominio.Habilitar(codigoCategoria);
            }
            if (respuesta == null) return NotFound();

            return Ok(respuesta);
        }
    }
}
