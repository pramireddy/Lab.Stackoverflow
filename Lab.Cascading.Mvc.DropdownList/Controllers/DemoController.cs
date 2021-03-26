using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Http;
using Lab.Cascading.Mvc.DropdownList.Models;

namespace MVCCore1.Controllers
{
    public class DemoController : Controller
    {
        private readonly List<Category> _categorylist;

        private readonly List<SubCategory> _subCategorylist;

        private readonly List<MainProduct> _productList;
        public DemoController()
        {
            _categorylist = GetCategories();
            _subCategorylist = GetSubCategories();
            _productList = GetProducts();
        }

        public IActionResult Index()
        {

            _categorylist.Insert(0, new Category { CategoryID = 0, CategoryName = "Select" });

            ViewBag.ListofCategory = _categorylist;
            ViewBag.Test = "Test123";
            return View();
        }

        [HttpPost]
        public IActionResult Index(Category objcategory, IFormCollection formCollection)
        {

            if (objcategory.CategoryID == 0)
            {
                ModelState.AddModelError("", "Select Category");
            }
            else if (objcategory.SubCategoryID == 0)
            {
                ModelState.AddModelError("", "Select SubCategory");
            }
            else if (objcategory.ProductID == 0)
            {
                ModelState.AddModelError("", "Select Product");
            }


            var SubCategoryID = HttpContext.Request.Form["SubCategoryID"].ToString();
            var ProductID = HttpContext.Request.Form["ProductID"].ToString();

            _categorylist.Insert(0, new Category { CategoryID = 0, CategoryName = "Select" });

            ViewBag.ListofCategory = _categorylist;
            return View(objcategory);
        }

        public JsonResult GetSubCategory(int CategoryID)
        {

            var subCategorylist = _subCategorylist.Where(x => x.CategoryID == CategoryID).ToList();

            subCategorylist.Insert(0, new SubCategory { SubCategoryID = 0, SubCategoryName = "Select" });


            return Json(new SelectList(subCategorylist, "SubCategoryID", "SubCategoryName"));
        }

        public JsonResult GetProducts(int SubCategoryID)
        {

            var productList = _productList.Where(x => x.SubCategoryID == SubCategoryID).ToList();

            productList.Insert(0, new MainProduct { ProductID = 0, ProductName = "Select" });

            return Json(new SelectList(productList, "ProductID", "ProductName"));
        }

        private static List<Category> GetCategories()
        {
            return new List<Category>
            {
                new Category
                {
                    CategoryID = 1, CategoryName = "CName 1"
                },
                new Category
                {
                    CategoryID = 2, CategoryName = "CName 2"
                },
                new Category
                {
                    CategoryID = 3, CategoryName = "CName 3"
                }
            };
        }

        private static List<SubCategory> GetSubCategories()
        {
            return new List<SubCategory>
            {
                new SubCategory
                {
                    CategoryID = 1, SubCategoryName = "Sub Category Name 11" , SubCategoryID = 1
                },
                new SubCategory
                {
                    CategoryID = 1, SubCategoryName = "Sub Category Name 12" , SubCategoryID = 2
                },
                new SubCategory
                {
                    CategoryID = 2, SubCategoryName = "Sub Category Name 22" , SubCategoryID = 3
                },

            };
        }

        private static List<MainProduct> GetProducts()
        {
            return new List<MainProduct>
            {
                new MainProduct
                {
                    ProductID = 1, SubCategoryID = 1,ProductName = "P Name 11"
                },
                new MainProduct
                {
                    ProductID = 2, SubCategoryID = 1,ProductName = "P Name 12"
                },
                new MainProduct
                {
                    ProductID = 3, SubCategoryID = 2,ProductName = "P Name 22"
                }

            };
        }
    }
}
