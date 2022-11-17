using Microsoft.AspNetCore.Mvc;
using Session.Models;
using System.Diagnostics;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace Session.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var student=new Student() {Id=10,Name="yeşim gerdan" ,Email="yesim@gmail.com"};
            //set the value into a session key
            //session kayıt ediyor 
            //5 saaat
            //kaydederken key değeri veriyouz studentsession

            //c# değeri json çevir =SerializeObject(student)
            // HttpContext.Session.SetString =kaydet
            HttpContext.Session.SetString("User",JsonConvert.SerializeObject(student));
            //kaydederken json convert ediyor :herhangi bir nesneyi hafızayı kaydetmek json amacı
            //session kaydederken student tipinde kaydediyor
            //görünümü:   var student=new Student() {Id=10,Name="yeşim gerdan" ,Email="yesim@gmail.com"};
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}