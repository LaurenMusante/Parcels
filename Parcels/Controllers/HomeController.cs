using Microsoft.AspNetCore.Mvc;
using ParcelInput.Models;

namespace ParcelInput.Controllers
{
  public class HomeController : Controller
  {
      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }

  }
}