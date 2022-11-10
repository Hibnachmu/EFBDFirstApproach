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
        EFCFADbContext db = new EFCFADbContext();
        // GET: Products
        public ActionResult Index(string search= "", string sortColumn = "ProductName", string iconClass = "fa-sort-asc", int pageNo =1)
        {

            ViewBag.search = search;
            List<Product> products = db.Products.Where(temp => temp.ProductName.Contains(search)).ToList();
            ViewBag.sortColumn = sortColumn;
            ViewBag.iconClass = iconClass;
            if(ViewBag.sortColumn == "ProductID")
            {
                if(ViewBag.iconClass == "fa-sort-asc")
                {
                    products = products.OrderBy(temp => temp.ProductID).ToList();
                }
                else
                {
                    products = products.OrderByDescending(temp => temp.ProductID).ToList();
                }
            }
            if (ViewBag.sortColumn == "ProductName")
            {
                if (ViewBag.iconClass == "fa-sort-asc")
                {
                    products = products.OrderBy(temp => temp.ProductName).ToList();
                }
                else
                {
                    products = products.OrderByDescending(temp => temp.ProductName).ToList();
                }
            }
            if (ViewBag.sortColumn == "Price")
            {
                if (ViewBag.iconClass == "fa-sort-asc")
                {
                    products = products.OrderBy(temp => temp.Price).ToList();
                }
                else
                {
                    products = products.OrderByDescending(temp => temp.Price).ToList();
                }
            }
            if (ViewBag.sortColumn == "AvailabilityStatus")
            {
                if (ViewBag.iconClass == "fa-sort-asc")
                {
                    products = products.OrderBy(temp => temp.AvailabilityStatus).ToList();
                }
                else
                {
                    products = products.OrderByDescending(temp => temp.AvailabilityStatus).ToList();
                }
            }
            if (ViewBag.sortColumn == "Active")
            {
                if (ViewBag.iconClass == "fa-sort-asc")
                {
                    products = products.OrderBy(temp => temp.Active).ToList();
                }
                else
                {
                    products = products.OrderByDescending(temp => temp.Active).ToList();
                }
            }
            if (ViewBag.sortColumn == "CategoryID")
            {
                if (ViewBag.iconClass == "fa-sort-asc")
                {
                    products = products.OrderBy(temp => temp.CategoryID).ToList();
                }
                else
                {
                    products = products.OrderByDescending(temp => temp.CategoryID).ToList();
                }
            }
            if (ViewBag.sortColumn == "BrandID")
            {
                if (ViewBag.iconClass == "fa-sort-asc")
                {
                    products = products.OrderBy(temp => temp.BrandID).ToList();
                }
                else
                {
                    products = products.OrderByDescending(temp => temp.BrandID).ToList();
                }
            }

            /*Paging*/
            int noOfRecordsPerPage = 5;
            int noOfPages = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(products.Count) / Convert.ToDouble(noOfRecordsPerPage)));
            int noOfRecordsToSkip = (pageNo - 1) * noOfRecordsPerPage;
            ViewBag.pageNo = pageNo;
            ViewBag.noOfPages = noOfPages;

            products = products.Skip(noOfRecordsToSkip).Take(noOfRecordsPerPage).ToList();
            return View(products);
        }

        public ActionResult Details(int id)
        {
            
            Product p = db.Products.Where(temp => temp.ProductID == id).FirstOrDefault();
            return View(p);
        }

        public ActionResult Create()
        {
           
            ViewBag.Categories = db.Categories.ToList();
            ViewBag.Brands = db.Brands.ToList();
            return View();
        }

        [HttpPost]
        public ActionResult Create([Bind(Include = "ProductID, ProductName, Price, Active, AvailabilityStatus, CategoryID, BrandID")]Product p)
        {
            if (ModelState.IsValid)
            {
               
                if (Request.Files.Count >= 1)
                {
                    var file = Request.Files[0];
                    var imageBytes = new Byte[0];

                    try

                    {

                        imageBytes = new Byte[file.ContentLength];

                        file.InputStream.Read(imageBytes, 0, file.ContentLength);

                    }

                    catch (Exception)

                    {

                        imageBytes = new Byte[file.ContentLength - 1];

                        file.InputStream.Read(imageBytes, 0, file.ContentLength);

                    }
                    file.InputStream.Read(imageBytes, 0, file.ContentLength);
                    var b64String = Convert.ToBase64String(imageBytes, 0, imageBytes.Length);
                    p.Photo = b64String;
                }
                db.Products.Add(p);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {

                return View();
            }
        }

        public ActionResult Edit(long id)
        {

            Product ep = db.Products.Where(temp => temp.ProductID == id).FirstOrDefault();
            ViewBag.Categories = db.Categories.ToList();
            ViewBag.Brands = db.Brands.ToList();
            return View(ep);
        }
        [HttpPost]
        public ActionResult Edit(Product p)
        {
            
            Product ep = db.Products.Where(temp => temp.ProductID == p.ProductID).FirstOrDefault();
            ep.ProductName = p.ProductName;
            ep.Price = p.Price;
            ep.DateOfPurchase = p.DateOfPurchase;
            ep.AvailabilityStatus = p.AvailabilityStatus;
            ep.BrandID = p.BrandID;
            ep.CategoryID = p.CategoryID;
            ep.Active = p.Active;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(long id)
        {
           
            Product ep = db.Products.Where(temp => temp.ProductID == id).FirstOrDefault();
            return View(ep);
        }
        [HttpPost]
        public ActionResult Delete(long id, Product p)
         {
            Product ep = db.Products.Where(temp => temp.ProductID == id).FirstOrDefault();
            db.Products.Remove(ep);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}