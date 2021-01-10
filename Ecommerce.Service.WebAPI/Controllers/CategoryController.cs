using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.BLL.Abstract;
using Ecommerce.Model.Entities;
using Ecommerce.Service.WebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Service.WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        ICategoryBLL categoryBLL;
        public CategoryController(ICategoryBLL bLL)
        {
            categoryBLL = bLL;
        }
  
        List<CategoryDTO> CategoryDTOList(ICollection<Category> listCategory)
        {
            List<CategoryDTO> catagories = new List<CategoryDTO>();

            foreach (Category item in listCategory)
            {
                catagories.Add(new CategoryDTO()
                {
                    CategoryID = item.ID,
                    CategoryName = item.CategoryName,
                    Description = item.Description,
                    IsActive=item.IsActive
                });
            }
            return catagories;
        }

        //ajax ile tüm kategorileri basmak için bu methodu oluşturdum method içerisinde bll'de kullanmış olduğum getall methodu kullanıldığı için tekrardan gidilip bll katmanına tanımlama yapmadım..

        public IActionResult GetCategory()
        {
            List<CategoryDTO> categories = CategoryDTOList(categoryBLL.GetAll());
            return Ok(categories);
        }
        public IActionResult GetCategoryActive()
        {
            List<CategoryDTO> categories = CategoryDTOList(categoryBLL.GetAllActive());
            return Ok(categories);
        }

        [HttpGet("{id}")]
        public IActionResult GetCategoryById(int id)
        {
            Category category = categoryBLL.Get(id);
            CategoryDTO categoryDTO = new CategoryDTO();
            categoryDTO.CategoryID = category.ID;
            categoryDTO.CategoryName = category.CategoryName;
            categoryDTO.Description = category.Description;
            return Ok(categoryDTO);

        }
        void NameControl(string CategoryName)
        {
            ICollection<Category> categories = categoryBLL.GetAll();
            foreach (Category item in categories)
            {
                if (item.CategoryName==CategoryName)
                {
                    throw new Exception($"{item.CategoryName} kayıtlarda böyle bu isimde kategori mevcut ");
                }
            }
        }

       


        [HttpPost]
        public IActionResult UpdateCategory([FromBody]CategoryDTO itemDto)
        {
            try
            {
                Category category = categoryBLL.Get(itemDto.CategoryID);
                category.CategoryName = itemDto.CategoryName;
                category.Description = itemDto.Description;
                category.IsActive = true;
                categoryBLL.Update(category);
                return Ok(new { message = "Kategori güncellendi", check=true });
            }
            catch (Exception ex)
            {
                return Ok(new { message = ex.Message, check=false });
            }
            
        }



        [HttpPost]
        public IActionResult AddCategory([FromBody]CategoryDTO categoryDTO)
        {
            try
            {
                NameControl(categoryDTO.CategoryName);

                Category category = new Category();
                category.ID = categoryDTO.CategoryID;
                category.CategoryName = categoryDTO.CategoryName;
                category.Description = categoryDTO.Description;
                categoryBLL.Insert(category);
                return Ok(new { message = "Kategori kaydedildi", check = true });
                
            }
            catch (Exception ex)
            {
                return Ok(new { message =ex.Message, check=false });
            }


        }

        [HttpGet("{id}")]
        public IActionResult DeleteCategoryById(int id)
        {          

            categoryBLL.DeleteByID(id);
            return Ok(new { message = "Kategori silindi", check = true });
        }


    }
}
