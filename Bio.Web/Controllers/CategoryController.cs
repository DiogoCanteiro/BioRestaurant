﻿using Bio.Web.Models;
using Bio.Web.Services.IServices;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bio.Web.Controllers
{
    public class CategoryController : Controller
    {
        private ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        public async Task<IActionResult> CategoryIndex()
        {
            List<CategoryDTO> list = new();
            var response = await _categoryService.GetAllCategoriesAsync<ResponseDTO>();

            if (response != null && response.IsSuccess)
            {
                list = JsonConvert.DeserializeObject<List<CategoryDTO>>(Convert.ToString(response.Result));
            }

            return View(list);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateCategory(CategoryDTO model)
        {
            if (ModelState.IsValid)
            {
                var accessToken = await HttpContext.GetTokenAsync("access_token");
                var response = await _categoryService.CreateCategoryAsync<ResponseDTO>(model, accessToken);

                if (response != null && response.IsSuccess)
                {
                    return RedirectToAction(nameof(CategoryIndex));
                }
            }

            return View(model);
        }

        public async Task<IActionResult> EditCategory(int categoryId)
        {
            var response = await _categoryService.GetCategoryByIdAsync<ResponseDTO>(categoryId);

            if (response != null && response.IsSuccess)
            {
                CategoryDTO model = JsonConvert.DeserializeObject<CategoryDTO>(Convert.ToString(response.Result));
                return View(model);
            }

            return NotFound();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditCategory(CategoryDTO model)
        {
            if (ModelState.IsValid)
            {
                var accessToken = await HttpContext.GetTokenAsync("access_token");
                var response = await _categoryService.UpdateCategoryAsync<ResponseDTO>(model, accessToken);

                if (response != null && response.IsSuccess)
                {
                    return RedirectToAction(nameof(CategoryIndex));
                }
            }

            return View(model);
        }

        public async Task<IActionResult> DeleteCategory(int categoryId)
        {
            var response = await _categoryService.GetCategoryByIdAsync<ResponseDTO>(categoryId);

            if (response != null && response.IsSuccess)
            {
                CategoryDTO model = JsonConvert.DeserializeObject<CategoryDTO>(Convert.ToString(response.Result));
                return View(model);
            }

            return NotFound();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteCategory(CategoryDTO model)
        {
            if (ModelState.IsValid)
            {
                var accessToken = await HttpContext.GetTokenAsync("access_token");
                var response = await _categoryService.DeleteCategoryAsync<ResponseDTO>(model.CategoryId, accessToken);

                if (response != null && response.IsSuccess)
                {
                    return RedirectToAction(nameof(CategoryIndex));
                }
            }

            return View(model);
        }
    }
}
