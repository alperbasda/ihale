using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ihale.Business.Abstract;
using Ihale.Business.Concrete.Managers;
using Ihale.Entity.ComplexType.GetModels.PageModels;
using Ihale.Entity.Concrete;

namespace Ihale.WebUI.Controllers
{
    public class CategoryController : Controller
    {
        private ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        // GET: Category
        [ChildActionOnly]
        public ActionResult PopularCategoryPartial()
        {
            List<Category> cat =  _categoryService.GetAll().ToList();
            return PartialView();
        }

        public ActionResult CategoryProduct()
        {
            return View();
        }
    }
}