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
        private readonly IEmailService _emailService;

        public AuthorizationController(Db4660Context context, IAuthorizationService authorizationService, IEmailService emailService)
        {
            _context = context;
            _authorizationService = authorizationService;
            _emailService = emailService;
        }


        [HttpPost(Name = "Registration")]
        public IActionResult Registr(string userEmail,string passCode)
        {
            var md5 = _authorizationService.CreateMD5Hash(passCode);
            var user = _context.Customers.FirstOrDefault(d => d.Email == userEmail);
            if(user != null)
                return BadRequest("Такой пользователь уже существует");
            var customer = new Customer()
            {
                Email = userEmail,
                UserName = userEmail.Split('@')[0],
                Passcode = md5
            };
            _context.Customers.Add(customer);
            _context.SaveChanges();
            _emailService.SendEmail("test", "", "ildar09@mail.ru");
            return Ok();
        }

         
        


    }
}
