using BusinessLayer.Concrete;
using DataAccess.Concrete;
using EntityLayer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace HastaneUI.Controllers
{
	public class HastaneController : Controller
	{
		HastaneManager hm = new HastaneManager(new HastaneDal());
        [Authorize(Roles = "Admin")]
        public IActionResult Index()
		{
			var values = hm.GetAllHastaneList();
			return View(values);
		}
        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult HastaneEkle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult HastaneEkle(Hastane hastane)
        {
            hm.AddHastane(hastane);
            return RedirectToAction("Index");
        }
        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult HastaneGuncelle(int id)
        {
            var values = hm.getHastaneByID(id);
            return View(values);
        }
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public IActionResult HastaneGuncelle(Hastane hastane)
        {
            hm.UpdateHastane(hastane);
            return RedirectToAction("Index");
        }
        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult HastaneSil(int id)
        {
            var result = hm.getHastaneByID(id);
            hm.DeleteHastane(result);

            return RedirectToAction("Index");

        }
    }
}
