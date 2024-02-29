using Crezco_Interview_CSharp.Services;
using Microsoft.AspNetCore.Mvc;

namespace Crezco_Interview_CSharp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IPInformationController : ControllerBase
    {
        private readonly IIPInformationService _ipInformationService;

        public IPInformationController(IIPInformationService ipInformationService)
        {
            _ipInformationService = ipInformationService;
        }

        [HttpGet]
        public async Task<string?> Get(string ipAddress)
        {
            return await _ipInformationService.GetInfoAsync(ipAddress);
        }
    }
}
