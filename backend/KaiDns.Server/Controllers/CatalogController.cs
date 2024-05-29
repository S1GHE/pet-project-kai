using KaiDns.Domain.Model;
using KaiDns.Server.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace KaiDns.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class CatalogController : ControllerBase
    {
        

        private readonly ILogger<CatalogController> _logger;
        private readonly Db4660Context _context;
        private readonly CatalogRepository _catalogRepository;

        public CatalogController(ILogger<CatalogController> logger,Db4660Context context, CatalogRepository catalogRepository)
        {
            _logger = logger;
            _context = context;
            _catalogRepository = catalogRepository;
        }

       

        [HttpGet(Name = "GetCatalog")]
        public  IActionResult GetCatalogs()
        {
            var catalogs = _catalogRepository.GetAll();
            return Ok(catalogs.ToList());
        }


    }
}