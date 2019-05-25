using Dip.Models;
using Dip.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Dip.Controllers
{
    public class AuthController : Controller
    {
        AuthService _authService;
        public AuthController()
        {
            _authService = new AuthService();
        }
        // GET: Auth
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                _authService.Register(model);
                FormsAuthentication.SetAuthCookie(model.Name, true);
                return RedirectToAction("Index", "Work");
            }
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(AuthModel model)
        {
            if (_authService.Login(model))
            {
                FormsAuthentication.SetAuthCookie(model.Login, true);
                return RedirectToAction("Index", "Work");
            }
            return View();
        }

        public ActionResult LogOff()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
    }
}