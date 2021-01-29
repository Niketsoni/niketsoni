using Microsoft.AspNetCore.Mvc;
using Niketsoni.Services;
using System.Threading.Tasks;

namespace Niketsoni.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEmailSender _emailSender;
        public HomeController( IEmailSender emailSender)
        {
            _emailSender = emailSender;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("api/RequestDemo")]
        public async Task<IActionResult> RequestDemo([FromBody] RequestDemo requestDemo)
        {
            var body = $"Subject: {requestDemo.Name}. Email: {requestDemo.Email}. Message: {requestDemo.Description}";
            await _emailSender.SendEmailAsync("", "From CodeNiket Contact", body);
            return Ok();
        }
    }
    public class RequestDemo
    {
        public string Email { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Description { get; set; }
    }
}
