using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Application.Models;

namespace Application.Controllers
{
    public class AdminController : Controller
    {
        Model1 db = new Model1();
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CreatShop()
        {
            return View();
        }
       

    }
}