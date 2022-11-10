using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EFDBFirstApproach.Models;
namespace EFDBFirstApproach.Controllers
{
    public class BrandsController : Controller
    {
        // GET: Brands
        public ActionResult Index()
        {
            EFCFADbContext db = new EFCFADbContext();
            List<Brand> brands = db.Brands.ToList();
            return View(brands);
        }
    }
}