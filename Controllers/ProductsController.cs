using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OnlineStoreZaliczenie.Data;
using OnlineStoreZaliczenie.Models;
using System.Globalization;

namespace OnlineStoreZaliczenie.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProductsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ProductsController
        public IActionResult Index()
        {
            // Pobierz produkty synchronnie
            var products = _context.Products.Include(P => P.Category).ToList();

            // Przekazanie danych do widoku
            return View(products);
        }

        // GET: ProductsController/Details/5
        public ActionResult Details(int id)
        {
            var product =  _context.Products.Include(P => P.Category).FirstOrDefault(p => p.ProductId == id);
            return View(product);
        }

        // GET: ProductsController/Create
        public ActionResult Create()
        {


            //var product = new Product();
            //product.Name = 

            //_context.Products.Add(product);
            //_context.SaveChanges();
            
            var categories = _context.Categories.ToList();
            ViewBag.CategoryId = new SelectList(categories, "CategoryId", "Name");

            return View();
        }

        // POST: ProductsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind("ProductId, Name, Description, Price, CategoryId")] 
        Product product)
        {
            try
            {
                var priceString = product.Price.ToString().Replace('.', ',');
                product.Price = decimal.Parse(priceString, new CultureInfo("pl-PL"));

                _context.Products.Add(product);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                var categories = _context.Categories.ToList();
                ViewBag.CategoryId = new SelectList(categories, "CategoryId", "Name");
                return View(product);
            }
        }

        // GET: ProductsController/Edit/5
        public ActionResult Edit(int id)
        {
            var product = _context.Products.Include(P => P.Category).FirstOrDefault(p => p.ProductId == id);
            var categories = _context.Categories.ToList();
            ViewBag.CategoryId = new SelectList(categories, "CategoryId", "Name");

            return View(product);
        }

        // POST: ProductsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, [Bind("ProductId, Name, Description, Price, CategoryId")]
        Product product)
        {
            try
            {
                //var priceString = product.Price.ToString().Replace('.', ',');
                //product.Price = decimal.Parse(priceString);
                _context.Products.Update(product);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                var categories = _context.Categories.ToList();
                ViewBag.CategoryId = new SelectList(categories, "CategoryId", "Name");
                return View(product);
            }
        }

        // GET: ProductsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProductsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
