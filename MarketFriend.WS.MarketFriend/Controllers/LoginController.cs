using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MarketFriend.WS.Dominio;
using MarketFriend.WS.Dominio.Contrato;
using MarketFriend.WS.Modelo.Response;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Net.Http;

namespace MarketFriend.WS.MarketFriend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        
        private readonly ILogger<LoginController> _logger;

        public LoginController(ILogger<LoginController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("logeatepapi")]
        public IEnumerable<MKFComercioResponse> GetTraerTodos()
        {
            List<MKFComercioResponse> oLista = null;
            using (IComercioDominio oDominio = new ComercioDominio())
            {
                oLista = oDominio.TraerTodos().ToList();
            }
            if (oLista == null) return null;

            return oLista;
        }
    }
}
