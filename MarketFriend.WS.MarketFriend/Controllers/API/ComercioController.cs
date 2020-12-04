using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using MarketFriend.WS.Dominio;
using MarketFriend.WS.Dominio.Contrato;
using MarketFriend.WS.Modelo.Request;
using MarketFriend.WS.Modelo.Response;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing.Constraints;
using Microsoft.Extensions.Logging;

namespace MarketFriend.WS.MarketFriend.Controllers.API
{
    [Route(Ruta.UriComercio.Prefijo)]
    [ApiController]
    //[Authorize]
    public class ComercioController : Controller
    {
        private readonly ILogger<ComercioController> _logger;
        public static IWebHostEnvironment _enviroment;

        public ComercioController(ILogger<ComercioController> logger, IWebHostEnvironment enviroment)
        {
            _logger = logger;
            _enviroment = enviroment;
        }

        [HttpGet]
        [Route(Ruta.UriComercio.TraerTodos)]
        public IActionResult TraerTodos()
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
        [Route(Ruta.UriComercio.TraerProximo)]
        public IActionResult TraerProximo(double GpsLatitud, double GpsLongitud)
        {
            List<MKFComercioResponse> oLista = null;
            using (IComercioDominio oDominio = new ComercioDominio())
            {
                oLista = oDominio.TraerProximo(GpsLatitud, GpsLongitud).ToList();
            }
            if (oLista == null) return NotFound();

            return Ok(oLista);
        }

        [HttpGet]
        [Route(Ruta.UriComercio.TraerUno)]
        public IActionResult TraerUno(int codigoComercio)
        {
            MKFComercioResponse oObjeto = null;
            using (IComercioDominio oDominio = new ComercioDominio())
            {
                oObjeto = oDominio.TraerUno(codigoComercio);
            }
            if (oObjeto == null) return NotFound();

            return Ok(oObjeto);
        }

        [HttpGet]
        [Route(Ruta.UriComercio.TraerNombre)]
        public IActionResult TraerNombre(string nombreComercio)
        {
            List<MKFComercioResponse> oLista = null;
            using (IComercioDominio oDominio = new ComercioDominio())
            {
                oLista = oDominio.TraerNombre(nombreComercio).ToList();
            }
            if (oLista == null) return NotFound();

            return Ok(oLista);
        }

        [HttpPost]
        [Route(Ruta.UriComercio.GrabarEditar)]
        public IActionResult GrabarEditar([FromForm]MKFComercioRequest oComercio)
        {
            
            bool respuesta = false;

            try
            {
                if (oComercio.Imagen.Length > 0)
                {
                    if (!Directory.Exists(_enviroment.WebRootPath + "\\Upload\\"))
                    {
                        Directory.CreateDirectory(_enviroment.WebRootPath + "\\Upload\\");
                    }
                    using (FileStream fileStream = System.IO.File.Create(_enviroment.WebRootPath+"\\Upload\\"+oComercio.Imagen.FileName.Replace(" ", "_")))
                    {
                        oComercio.Imagen.CopyTo(fileStream);
                        fileStream.Flush();
                        using (IComercioDominio oDominio = new ComercioDominio())
                        {
                            respuesta = oDominio.GrabarEditar(oComercio);
                        }
                        if (respuesta == null) return NotFound();

                        return Ok(respuesta);

                       
                    }


                }
                else
                {
                   return Ok("failed");
                }

            }
            catch (Exception e)
            {
                return Ok(e.Message.ToString());
            }
           

        }


        [HttpDelete]
        [Route(Ruta.UriComercio.Eliminar)]
        public IActionResult Eliminar(int codigoComercio)
        {
            bool respuesta = false;
            using (IComercioDominio oDominio = new ComercioDominio())
            {
                respuesta = oDominio.Eliminar(codigoComercio);
            }
            if (respuesta == null) return NotFound();

            return Ok(respuesta);
        }

        [HttpPut]
        [Route(Ruta.UriComercio.Habilita)]
        public IActionResult Habilitar(int codigoComercio)
        {
            bool respuesta = false;
            using (IComercioDominio oDominio = new ComercioDominio())
            {
                respuesta = oDominio.Habilitar(codigoComercio);
            }
            if (respuesta == null) return NotFound();

            return Ok(respuesta);
        }

        [HttpGet]
        [Route(Ruta.UriComercio.TraerCategoria)]
        public IActionResult TraerCategoria(int codigoCategoria)
        {
            List<MKFComercioResponse> oLista = null;
            using (IComercioDominio oDominio = new ComercioDominio())
            {
                oLista = oDominio.TraerCategoria(codigoCategoria).ToList();
            }
            if (oLista == null) return NotFound();

            return Ok(oLista);
        }


        [HttpGet]
        [Route(Ruta.UriComercio.MejorCalificado)]
        public IActionResult TraerMejorCalificado(float gpsLatitud, float gpsLongitud)
        {
            MKFComercioResponse oObjeto = null;
            using (IComercioDominio oDominio = new ComercioDominio())
            {
                oObjeto = oDominio.TraerMejorCalificado(gpsLatitud, gpsLongitud);
            }
            if (oObjeto == null) return NotFound();

            return Ok(oObjeto);
        }


        [HttpPost]
        [Route(Ruta.UriComercio.Clasificacion)]
        public IActionResult CalificaComercio([FromBody] MKFClasificacionRequest oCalifica)
        {
            List<MKFMensajeResponse> oLista = null;
            using (IComercioDominio oDominio = new ComercioDominio())
            {
                oLista = oDominio.CalificaComercio(oCalifica).ToList();
            }
            if (oLista == null) return NotFound();

            return Ok(oLista);
        }

    }
}
