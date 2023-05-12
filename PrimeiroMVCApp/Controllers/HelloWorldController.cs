using Microsoft.AspNetCore.Mvc;
using PrimeiroMVCApp.Models;

namespace PrimeiroMVCApp.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            DogViewModel doggo = new DogViewModel()
            { Name="Sif", Age=2};
            return View(doggo);
        }

        public string Hello() 
        {
            return "Who is there?";
        }
    }
}
