using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Application.Models;

namespace Application.Controllers
{
    public class AnnouncementController : Controller
    {
        Model1 db = new Model1();
        public ActionResult Index(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Shop shop = db.Shops.Find(id);
            if (shop == null)
            {
                return HttpNotFound();
            }
            return View(shop);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index([Bind(Include = "id,Name,Email,Queue,Password,Adress,Number,Image,Coverphoto,Role,Partner,Position,Opentime,Closetime,About")] Shop shop)
        {
            if (ModelState.IsValid)
            {
                db.Entry(shop).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(shop);
        }
        public ActionResult Announce()
        {
            return View(db.Shops.FirstOrDefault());
        }
        [HttpPost]
        public ActionResult Announce(Application.Models.Type type,Product product, Image a, HttpPostedFileBase[] Image)
        {
            foreach (var file in Image)
            {
                if (file != null)
                {
                    var InputFileName = Path.GetFileName(file.FileName);
                    var ServerSavePath = Path.Combine(Server.MapPath("~/images/Upload/") + InputFileName);
                    string yyy = Guid.NewGuid().ToString() + InputFileName;
                    file.SaveAs(ServerSavePath);
                    a.Image1 = Image;
                    db.Images.Add(a);
                    db.SaveChanges();

                }

            }
            
            //string filename = Image.FileName;
            //string ext = Path.GetExtension(a.Image1.);
            //string yyy = Guid.NewGuid().ToString() + filename;
            //var yuklemeyeri = Server.MapPath("~/Images/Upload/") + yyy;
            //Image.SaveAs(yuklemeyeri);
            //a.Image1 = yyy;
            //db.Images.Add(a);

            //var b = Convert.ToInt16(Session["sid"]);
            //Application.Models.Type model = new Application.Models.Type();
            //product.Shop_id= b;
            //product.Seen = 0;
            //db.Products.Add(product);

            //db.Products.Add(product);

            //string[] nm = new string[4];
            //foreach (var item in nm)
            //{
            //    db.Types.Add(type);
            //}
            return View();
        }
    }
}