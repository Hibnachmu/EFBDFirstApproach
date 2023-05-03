using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EFDBFirstApproach.Models;

namespace EFDBFirstApproach.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            EFCFADbContext db = new EFCFADbContext();
            List<Product> products = db.Products.ToList();
            return View(products);
        }
    }
}