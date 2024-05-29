using KaiDns.Domain.Model;
using KaiDns.Server.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace KaiDns.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorizationController : ControllerBase
    {
        private readonly Db4660Context _context;
        private readonly IAuthorizationService _authorizationService;

        public AuthorizationController(Db4660Context context, IAuthorizationService authorizationService)
        {
            _context = context;
            _authorizationService = authorizationService;
        }


        [HttpGet(Name = "Registration")]
        public IActionResult Registr(string pass,int userId)
        {
            var md = _authorizationService.CreateMD5Hash(pass);
            var user = _context.Customers.FirstOrDefault(d => d.CustomerId == userId);
            user.Passcode = md;
            _context.SaveChanges();
            return Ok(md);
        }
    }
}
