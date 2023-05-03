using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EFDBFirstApproach.Models;

namespace EFDBFirstApproach.Areas.Admin.Controllers
{
    public class CategoriesController : Controller
    {
        // GET: Admin/Categories
        public ActionResult Index()
        {
            EFCFADbContext db = new EFCFADbContext();
            List<Category> categories = db.Categories.ToList();
            return View(categories);
        }
    }
}