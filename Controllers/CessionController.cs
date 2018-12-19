using System;
using Microsoft.AspNetCore.Mvc;
using SitePeche.Services;

namespace SitePeche.Controllers
{
    public class CessionController : Controller
    {
        public IActionResult Index()
        {
            return View(DbCessionGetAll.Instance().CessionGetAll());
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Detail(int id)
        {
            ViewBag.prise = DbPriseGetAll.Instance().PriseGetAll(id);
            return View(DbCessionGetOne.Instance().CessionGetOne(id));
        }
    }
}