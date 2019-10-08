using Microsoft.AspNetCore.Mvc;
using ParcelInput.Models;
using System.Collections.Generic;

namespace ParcelInput.Controllers
{
 public class ItemsController : Controller
 {
     [HttpGet("/items")]
     public ActionResult Index()
     {
      List<Parcel> allParcels = Parcel.GetAll();
      return View(allParcels);
     }

     [HttpPost("/items")]
     public ActionResult Create(int length, int width, int height)
     {
         Parcel newParcel = new Parcel(length, width, height);
         return RedirectToAction("Index");
     }
 }
}

