using Bio.Services.Business.Interfaces;
using Bio.Services.Models;
using Bio.Services.ProductAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bio.Services.ProductAPI.Controllers
{
    [Route("/api/categories")]
    public class CategoryAPIController : ControllerBase
    {
        protected ResponseDTO _response;
        private ICategoryService _categoryService;

        public CategoryAPIController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
            _response = new ResponseDTO();
        }

        [HttpGet]
        public async Task<object> Get()
        {
            try
            {
                IEnumerable<CategoryDTO> categoryDTOs = await _categoryService.GetCategories();
                _response.Result = categoryDTOs;
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>
                {
                    ex.ToString()
                };
            }

            return _response;
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<object> Get(int id)
        {
            try
            {
                CategoryDTO categoryDTO = await _categoryService.GetCategoryById(id);
                _response.Result = categoryDTO;
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>
                {
                    ex.ToString()
                };
            }

            return _response;
        }

        [HttpPost]
        public async Task<object> Post([FromBody] CategoryDTO categoryDTO)
        {
            try
            {
                CategoryDTO model = await _categoryService.CreateUpdateCategory(categoryDTO);
                _response.Result = model;
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>
                {
                    ex.ToString()
                };
            }

            return _response;
        }

        [HttpPut]
        public async Task<object> Put([FromBody] CategoryDTO categoryDTO)
        {
            try
            {
                CategoryDTO model = await _categoryService.CreateUpdateCategory(categoryDTO);
                _response.Result = model;
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>
                {
                    ex.ToString()
                };
            }

            return _response;
        }

        [HttpDelete]
        public async Task<object> Delete(int id)
        {
            try
            {
                bool isSuccess = await _categoryService.DeleteCategory(id);
                _response.Result = isSuccess;
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>
                {
                    ex.ToString()
                };
            }

            return _response;
        }
    }
}
