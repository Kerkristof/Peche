using System;
using Microsoft.AspNetCore.Mvc;
using SitePeche.Services;
using SitePeche.Models;

namespace SitePeche.Controllers
{
    public class EspeceController : Controller
    {
        public IActionResult Index()
        {
            return View(DbEspeceGetAll.Instance().EspeceGetAll());
        }
        // GET: Espece/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(string nom, string nom_alt, int taille_min)
        {
            DbEspeceCreate.Instance().EspeceCreate(nom, nom_alt, taille_min);
            return RedirectToAction("Index");
        }
    }
}