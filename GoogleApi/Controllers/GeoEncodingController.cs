using GoogleApi.pplication.Dtos.GoogleGlobal;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GoogleApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GeoEncodingController : ControllerBase
    {
        [HttpPost]
        public async Task<ActionResult<object>> Pos(CordenadasDto cordenadasDto)
        {
            return Ok();
        }
    }
}
