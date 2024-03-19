using Microsoft.AspNetCore.Mvc;
using Portafolio_ASA.PortafolioASA.Services;

namespace PortafolioASA.Controllers;

[ApiController]
[Route("[controller]")]
public class PortafolioASAController : ControllerBase
{
    private readonly ILogger<PortafolioASAController> _logger;
    private readonly PortafolioServices _portafolioServicio;

    public PortafolioASAController(ILogger<PortafolioASAController> logger, PortafolioServices portafolioServices)
    {
        _logger = logger;
        _portafolioServicio = portafolioServices;
    }

    [HttpGet]
    public async Task<IActionResult> GetDatos()
    {
        var portafolio = await _portafolioServicio.GetAsync();
        return Ok(portafolio);
    }
    
}
