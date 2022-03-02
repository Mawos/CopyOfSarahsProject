// using Microsoft.AspNetCore.Mvc;
// using Places.Models;
// using System.Collections.Generic;

// namespace Places.Controllers
// {
//   public class PlacesController : Controller
//   {

//     [HttpGet("/places")]
//     public ActionResult Index()
//     {
//       List<Item> allItems = Item.GetAll();
//       return View(allItems);
//     }

//     [HttpGet("/places/new")]
//     public ActionResult New()
//     {
//       return View();
//     }

//     [HttpPost("/places")]
//     public ActionResult Create(string description)
//     {
//       Item myItem = new Item(description);
//       return RedirectToAction("Index");
//     }

//     [HttpGet("/places/{id}")]
//     public ActionResult Show(int id)
//     {
//       Item foundItem = Item.Find(id);
//       return View(foundItem);
//     }

//     [HttpPost("/places/delete")]
//     public ActionResult DeleteAll()
//     {
//       Item.ClearAll();
//       return View();
//     }
//   }
// }