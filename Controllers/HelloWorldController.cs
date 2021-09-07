using Microsoft.AspNetCore.Mvc;

namespace ApplicationMVC.Controllers
{
  public class HelloWorldController : Controller
  {
    public HelloWorldController() : base ()
    {}


    public IActionResult Index () {
      return View();
    }

    // 
    // GET: /HelloWorld/bemvindo/ 
    public IActionResult Welcome (string nome, int numero, int ID) {
      ViewData["Message"] = $"Hello {nome}";
      ViewData["Numero"] = numero;
      ViewData["ID"] = ID;
      return View();
    }
  }
}