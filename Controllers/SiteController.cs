using System;
using Microsoft.AspNetCore.Mvc;
using SitePeche.Services;

namespace SitePeche.Controllers
{
    public class SiteController : Controller
    {
        public IActionResult Index()
        {
            return View(DbSiteGetAll.Instance().SiteGetAll());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(string nom)
        {
            DbSiteCreate.Instance().SiteCreate(nom);
            return RedirectToAction("Index");
        }

        public IActionResult Detail(int id)
        {
            ViewBag.spot = DbSpotGetAll.Instance().SpotGetAll(id);
            return View(DbSiteGetOne.Instance().SiteGetOne(id));
        }
    }
}