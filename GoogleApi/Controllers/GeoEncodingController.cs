using GoogleApi.Domain.Parameters;
using GoogleApi.pplication.Dtos.GoogleEncoding;
using GoogleApi.pplication.Dtos.GoogleGlobal;
using GoogleApi.pplication.Inferfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Globalization;

namespace GoogleApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GeoEncodingController : ControllerBase
    {
        private readonly IEnxtensionServices _services;

        public GeoEncodingController(IEnxtensionServices services)
        {
            _services = services;
        }

        [HttpPost]
        public async Task<ActionResult<object>> Pos(CordenadasDto entidad)
        {
            var encontrado = await _services.globalAdressServicio.Post(entidad);
            if (encontrado != null)
            {
                return Ok(encontrado);
            }
             return BadRequest(Tools.messageError);
         
        }
    }
}
