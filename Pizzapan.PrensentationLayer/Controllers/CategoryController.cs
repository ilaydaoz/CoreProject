﻿using Microsoft.AspNetCore.Mvc;
using Pizzapan.BussinesLayer.Absrtact;
using Pizzapan.EntityLayer.Concrete;

namespace Pizzapan.PrensentationLayer.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
            var values = _categoryService.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddCategory(Category category)
        {
            _categoryService.TInsert(category);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteCategory(int id)
        {
           var value = _categoryService.TGetByID(id);
            _categoryService.TDelete(value);    
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateCategory(int id)
        {
            var value = _categoryService.TGetByID(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateCategory(Category category)
        {
            _categoryService.TUpdate(category);
            return RedirectToAction("Index");
        }
    }
}
