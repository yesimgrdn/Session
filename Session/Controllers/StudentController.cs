using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Session.Models;
namespace Session.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            //okuma tarayıcıdan
            //get session info
            //user oku student çevir
            var student = JsonConvert.DeserializeObject<Student>(HttpContext.Session.GetString("User"));
            return View(student);
        }
    }
}
