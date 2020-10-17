using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Common.Infrastructure.ViewModel.Admin;
using Ecommerce.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Admin.Controllers
{
    public class ProductController : Controller
    {
        private readonly EcommerceDbContext _db;
        //private readonly ICartDetailsServices _cartDetailsService;

        //public ProductController(ICartDetailsServices cartDetailsService)
        //{
        //    _cartDetailsService = cartDetailsService;
        //}
        // GET: ProductController
        public async Task<IActionResult> Index(string sortOrder)
        {
            var listProduct = _db.Products.AsQueryable();
            if (string.IsNullOrEmpty(sortOrder))
            {
                sortOrder = "NameProduct_Asc";
            }
            switch (sortOrder)
            {
                case "NameProduct_Asc":
                    listProduct = listProduct.OrderBy(p => p.Name);
                    break;
                case "NameProduct_Desc":
                    listProduct = listProduct.OrderByDescending(p => p.Name);
                    break;
                case "PriceProduct_Asc":
                    listProduct = listProduct.OrderBy(p => p.Price);
                    break;
                case "PriceProduct_Desc":
                    listProduct = listProduct.OrderByDescending(p => p.Price);
                    break;
            }
            ViewBag.OrderType = sortOrder;
            //var models = await _cartDetailsService.GetListCartDetails();
            return View();
        }

        // GET: ProductController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProductController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: ProductController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProductController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
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

        // GET: ProductController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProductController/Delete/5
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
