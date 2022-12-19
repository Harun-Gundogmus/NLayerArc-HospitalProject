using BusinessLayer.Concrete;
using DataAccess.Concrete;
using EntityLayer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace HastaneUI.Controllers
{
    public class PersonelController : Controller
    {
        PersonelManager pm = new PersonelManager(new PersonelDal());
        [Authorize(Roles = "Admin")]
        public IActionResult Index()
        {
            var values = pm.GetAllPersonelList();
            return View(values);
        }
        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult PersonelEkle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult PersonelEkle(Personel personel)
        {
            pm.AddPersonel(personel);
            return RedirectToAction("Index");
        }
        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult PersonelGuncelle(int id)
        {
            var values = pm.getPersonelById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult PersonelGuncelle(Personel personel)
        {
            pm.UpdatePersonel(personel);
            return RedirectToAction("Index");
        }
        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult PersonelSil(int id)
        {
            var result = pm.getPersonelById(id);
            pm.DeletePersonel(result);

            return RedirectToAction("Index");

        }
    }
}
