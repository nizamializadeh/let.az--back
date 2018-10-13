using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Application.Models;

namespace Let.az.Controllers
{
    [RequireHttps]
    public class HomeController : Controller
    {
        Model1 db = new Model1();
        public ActionResult Index(int? id)
        {
            Viewmodel vm = new Viewmodel();
            vm.user = db.Users.Find(id);
            vm.ie_shop = db.Shops.ToList();
            return View(vm);
        }
        public ActionResult Company()
        {
            return View();
        }
        public ActionResult Bestselling()
        {
            Viewmodel vm = new Viewmodel();
            vm.ie_product = db.Products.ToList();
            vm.ie_Rate = db.Rates.ToList(); 
            return View(vm);
        }
        public ActionResult Companies()
        {

            return View(db.Shops.ToList());
        }
        public ActionResult About()
        {
            return View(db.Abouts.ToList());
        }
        public ActionResult Like(int? id)
        {
            Viewmodel vm = new Viewmodel();
            vm.user = db.Users.Find(id);
            vm.ie_like = db.Likes.ToList();
            return View(vm);
        }
        public ActionResult Search(string searchString)
        {
            var praducts = from a in db.Products
                           select a;
            if (!string.IsNullOrEmpty(searchString))
            {
                praducts = praducts.Where(s => s.Name.Contains(searchString));
            }
            return View(praducts);
        }
        public ActionResult Category(int? id)
        {
            Viewmodel vm = new Viewmodel();
            vm.catagory = db.Catagories.Find(id);
            vm.ie_shop = db.Shops.ToList();
            return View(vm);
        }
        public ActionResult Detail(int? id)
        {
            Viewmodel vm = new Viewmodel();
            vm.product = db.Products.Find(id);
            vm.ie_Rate = db.Rates.ToList();
            return View(vm);
        }
        [HttpPost]
        public ActionResult Detail(FormCollection frm)
        {
            Like model = new Like();
            model.Product_id= Convert.ToInt16(frm["puraducid"]);
            model.User_id = Convert.ToInt16(Session["id"]);
            db.Likes.Add(model);
            db.SaveChanges();
            return View();
        }
        public ActionResult Shop(int? id)
        {
            Viewmodel vm = new Viewmodel();
            vm.ie_photo = db.PhotoGallereys.ToList();
            vm.shop = db.Shops.Find(id);
            vm.ie_product = db.Products.ToList();
            return View(vm);
        }
        public ActionResult Test(int? id)
        {
            return View(db.Shops.ToList());
        }
        public PartialViewResult Counter()
        {
            return PartialView(db.Counters.FirstOrDefault());
        }
        public PartialViewResult Advertising()
        {
            return PartialView(db.Advertisings.FirstOrDefault());
        }
        public PartialViewResult AdvertisingTwo()
        {
            return PartialView(db.Advertisings.FirstOrDefault());
        }
        public PartialViewResult Catagory()
        {
                
                return PartialView(db.Catagories.ToList());
            
        }
        public ActionResult Seenplus(int? id)
        {
            var product = db.Products.Where(s => s.id == id).SingleOrDefault();
            product.Seen += 1;
            db.SaveChanges();
            return View();
        }
        public ActionResult SeenplusShop(int? id)
        {
            var shop = db.Shops.Where(s => s.id == id).SingleOrDefault();
            shop.Seen_shop += 1;
            db.SaveChanges();
            return View();
        }
        public ActionResult Rateyo(FormCollection frm)
        {
            Rate model = new Rate();    
            var id = Request.Form["id"];
            int a =Convert.ToInt32(id)*20;
            var pid = Convert.ToInt16(frm["puraducid"]);
            model.User_id = Convert.ToInt16(Session["id"]);
            model.cost = id;
            model.Product_id = pid;
            db.Rates.Add(model);
             db.SaveChanges();
            return Json(id);
            
        }
        //[HttpPost]
        //public JsonResult Catagory(Catagory cat)
        //{
        //    using (var ctx = new Model1())
        //    {
        //        var id = Request.Form["categoryId"];
        //        var studentList = ctx.Catagories.SqlQuery("Select * from Catagory where Catagory.Cat_id=" + id).ToList<Catagory>();
        //        return Json(studentList);
        //    }

        //}
    }
}
