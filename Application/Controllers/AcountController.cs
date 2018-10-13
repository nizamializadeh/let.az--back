using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using System.Web.Security;
using Application.Models;

namespace Application.Controllers
{
    public class AcountController : Controller
    {
        Model1 db = new Model1();
        public ActionResult Login()
        {
            return View();
        }

        //
        // POST: /Account/Login
        [HttpPost]
        public ActionResult Login(User usr)
        {
            var pass = Crypto.Hash(usr.Password, "MD5");
            var data = db.Users.FirstOrDefault(a => a.Email == usr.Email && a.Password == pass);
            if (data != null)
            {
                Session["id"] = data.id;
                Session["ad"] = data.Name;
                Session["role"] = data.Role;
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.mesaj = "Parol ve ya Name sehvdi..";
                return View();
            }

        }
        public ActionResult LoginShop()
        {
            return View();
        }


        [HttpPost]
        public ActionResult LoginShop(Shop shop)
        {
            var pass = Crypto.Hash(shop.Password, "MD5");
            var data = db.Shops.FirstOrDefault(a => a.Email == shop.Email && a.Password == shop.Password);
            if (data != null)
            {
                Session["sid"] = data.id;
                Session["sad"] = data.Name;
                Session["srole"] = data.Role;
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.mesaj = "Parol ve ya Name sehvdi..";
                return View();
            }

        }
        // GET: registerforadmin
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(User usr)
        {
            var parol = Request.Form["Password"];
            usr.Password = Crypto.Hash(parol, "MD5");
            db.Users.Add(usr);
            db.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
        public ActionResult Logout()
        {
            Session["id"] = null;
            Session.Abandon();
            return RedirectToAction("Index", "Home");
        }
        public ActionResult Admin()
        {
            return View();
        }

        //
        // POST: /Account/Login
        [HttpPost]
        public ActionResult Admin(User usr)
        {
            var pass = Crypto.Hash(usr.Password, "MD5");
            var data = db.Users.FirstOrDefault(a => a.Email == usr.Email && a.Password == pass);
            if (data != null)
            {
                Session["id"] = data.id;
                Session["ad"] = data.Name;
                Session["role"] = data.Role;
                return RedirectToAction("Index", "Admin");
            }
            else
            {
                ViewBag.mesaj = "Parol ve ya Name sehvdi..";
                return View();
            }


        }
    }
}