using DataAccess;
using EntityLayer;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace HastaneUI.Controllers
{
    public class AdminController : Controller
    {
        [HttpGet]
        public IActionResult Index(string returnUrl)
        {
            TempData["returnUrl"] = returnUrl;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(Login login)
        {
            Context c = new Context();
            var admin = c.Logins.FirstOrDefault(x => x.UserName == login.UserName && x.UserPassword == login.UserPassword);
            if (admin != null)
            {
                var claims = new List<Claim>
                { new Claim(ClaimTypes.Name, admin.UserName),
                 new Claim(ClaimTypes.Role, admin.UserRole)
                };


                var useridentity = new ClaimsIdentity(claims, "Login");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);

                await HttpContext.SignInAsync(principal);

                if (TempData["returnUrl"] != null)
                {
                    if (Url.IsLocalUrl(TempData["returnUrl"].ToString()))
                    {
                        return Redirect(TempData["returnUrl"].ToString());
                    }
                }
                else
                {
                    return RedirectToAction("Index", "Personel");
                }

            }

            return View();

        }
    }
}
