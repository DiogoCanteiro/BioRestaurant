using Bio.Web.Models;
using Bio.Web.Services.IServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bio.Web.Controllers
{
    public class ProductController : Controller
    {
        private IProductService _productService;
        private ICategoryService _categoryService;

        public ProductController(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }
        public async Task<IActionResult> ProductIndex()
        {
            List<ProductDTO> list = new();
            var response = await _productService.GetAllProductsAsync<ResponseDTO>();

            if(response != null && response.IsSuccess)
            {
                list = JsonConvert.DeserializeObject<List<ProductDTO>>(Convert.ToString(response.Result));
            }

            return View(list);
        }

        public async Task<IActionResult> CreateProduct()
        {
            await PopulateCategories();

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateProduct(ProductDTO model)
        {
            if (ModelState.IsValid)
            {
                var response = await _productService.CreateProductAsync<ResponseDTO>(model);

                if (response != null && response.IsSuccess)
                {
                    return RedirectToAction(nameof(ProductIndex));
                }
            }
            else
            {
                await PopulateCategories();
            }
           
            return View(model);
        }

        public async Task<IActionResult> EditProduct(int productId)
        {
            var response = await _productService.GetProductByIdAsync<ResponseDTO>(productId);

            if (response != null && response.IsSuccess)
            {
                ProductDTO model = JsonConvert.DeserializeObject<ProductDTO>(Convert.ToString(response.Result));

                await PopulateCategories();

                return View(model);
            }

            return NotFound();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditProduct(ProductDTO model)
        {
            if (ModelState.IsValid)
            {
                var response = await _productService.UpdateProductAsync<ResponseDTO>(model);

                if (response != null && response.IsSuccess)
                {
                    return RedirectToAction(nameof(ProductIndex));
                }
            }
            else
            {
                await PopulateCategories();
            }

            return View(model);
        }

        public async Task<IActionResult> DeleteProduct(int productId)
        {
            var response = await _productService.GetProductByIdAsync<ResponseDTO>(productId);

            if (response != null && response.IsSuccess)
            {
                ProductDTO model = JsonConvert.DeserializeObject<ProductDTO>(Convert.ToString(response.Result));

                await PopulateCategories();

                return View(model);
            }

            return NotFound();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteProduct(ProductDTO model)
        {
            if (ModelState.IsValid)
            {
                var response = await _productService.DeleteProductAsync<ResponseDTO>(model.ProductId);

                if (response != null && response.IsSuccess)
                {
                    return RedirectToAction(nameof(ProductIndex));
                }
            }
            else
            {
                await PopulateCategories();
            }

            return View(model);
        }

        private async Task PopulateCategories()
        {
            var response = await _categoryService.GetAllCategoriesAsync<ResponseDTO>();

            if (response != null && response.IsSuccess)
            {
                List<CategoryDTO> categories = JsonConvert.DeserializeObject<List<CategoryDTO>>(Convert.ToString(response.Result));

                ViewBag.Categories = new SelectList(categories, "CategoryId", "Name");
            }
        }
    }
}
