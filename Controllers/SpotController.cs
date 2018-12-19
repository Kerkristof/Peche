using System;
using Microsoft.AspNetCore.Mvc;
using SitePeche.Services;

namespace SitePeche.Controllers
{
    public class SpotController : Controller
    {
        public IActionResult Create(int id)
        {
            ViewBag.SiteId = id;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(string nom, string gps, int id_site)
        {
            DbSpotCreate.Instance().SpotCreate(nom, gps, id_site);
            return RedirectToAction("Index");
        }
    }
}