using BusinessLayer.Concrete;
using DataAccess.Concrete;
using EntityLayer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace HastaneUI.Controllers
{
    public class PoliklinikController : Controller
    {
        PoliklinikManager pm = new PoliklinikManager(new PoliklinikDal());
        [Authorize(Roles = "Admin")]
        public IActionResult Index()
        {
            var values = pm.GetAllPoliklinikList();
            return View(values);
        }
        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult PoliklinikEkle()
        {
            return View();
        }
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public IActionResult PoliklinikEkle(Poliklinik poliklinik)
        {
            pm.AddPoliklinik(poliklinik);
            return RedirectToAction("Index");
        }
        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult PoliklinikGuncelle(int id)
        {
            var values = pm.GetPoliklinikById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult PoliklinikGuncelle(Poliklinik poliklinik)
        {
            pm.UpdatePoliklinik(poliklinik);
            return RedirectToAction("Index");
        }
        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult PoliklinikSil(int id)
        {
            var result = pm.GetPoliklinikById(id);
            pm.DeletePoliklinik(result);

            return RedirectToAction("Index");

        }
    }
}
