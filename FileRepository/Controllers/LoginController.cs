using Microsoft.AspNetCore.Mvc;

namespace FileRepository.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
