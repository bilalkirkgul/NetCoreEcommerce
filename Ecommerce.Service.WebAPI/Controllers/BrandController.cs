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
    public class BrandController : ControllerBase
    {
        IBrandBLL brandBLL;

        public BrandController(IBrandBLL bll)
        {
            brandBLL = bll;
        }

        //marka listesini dto listesine çevirme methodu

        List<BrandDTO> BrandDTOList(ICollection<Brand> listBrand)
        {
            List<BrandDTO> brands = new List<BrandDTO>();
            foreach (Brand item in listBrand)
            {
                brands.Add(new BrandDTO()
                {
                    BrandID = item.ID,
                    BrandName=item.BrandName,
                    Description=item.Description,
                    IsActive=item.IsActive
                    
                });
                
            }
            return brands;
        }
        //ajax ile tüm markaları basmak için bu methodu oluşturdum method içerisinde bll'de kullanmış olduğum getall methodu kullanıldığı için tekrardan gidilip bll katmanına tanımlama yapmadım..
        public IActionResult GetBrand()
        {
            List<BrandDTO> brands = BrandDTOList(brandBLL.GetAll());//getall olduğu için bll tarafına eklenmedi
            return Ok(brands);
        }

        public IActionResult GetBrandActive()
        {
            List<BrandDTO> brands = BrandDTOList(brandBLL.GetAllActive());//getall olduğu için bll tarafına eklenmedi
            return Ok(brands);
        }

        #region alternatif
        //public IActionResult GetBrand() alternatif....
        //{

        //    return Ok(BrandDTOList(brandBLL.GetAll()));
        //} 
        #endregion




        void NameControl(string Name)
        {
            ICollection<Brand> brands = brandBLL.GetAll();
            foreach (Brand item in brands)
            {
                if (item.BrandName == Name)
                {
                    throw new Exception($"{item.BrandName} kayıtlarda böyle bu isimde marka mevcut ");
                }
            }
        }


        [HttpGet("{id}")]
        public IActionResult GetBrandById(int id)
        {
            Brand brand = brandBLL.Get(id);
            BrandDTO brandDTO = new BrandDTO();
            brandDTO.BrandID = brand.ID;
            brandDTO.BrandName = brand.BrandName;
            brandDTO.Description = brand.Description;
            return Ok(brandDTO);
        }


        [HttpPost]
        public IActionResult AddBrand([FromBody] BrandDTO brandDTO)
        {
            try
            {
                NameControl(brandDTO.BrandName);

                Brand brand = new Brand();
                brand.ID = brandDTO.BrandID;
                brand.BrandName = brandDTO.BrandName;
                brand.Description = brandDTO.Description;
                brandBLL.Insert(brand);
                return Ok(new { message = "Marka eklendi", check = true });

            }
            catch (Exception ex)
            {

                return Ok(new { message = ex.Message, check = false });
            }
        }



        [HttpPost]
        public IActionResult UpdateBrand([FromBody] BrandDTO brandDTO)
        {
            try
            {
                Brand brand = brandBLL.Get(brandDTO.BrandID);
                brand.BrandName = brandDTO.BrandName;
                brand.Description = brandDTO.Description;
                brand.IsActive = true;
                brandBLL.Update(brand);
                return Ok(new { message = "Marka güncellendi", check=true });
            }
            catch (Exception ex)
            {

                return Ok(new { message = ex.Message, check = false });
            }
        }


        [HttpGet("{id}")]
        public IActionResult DeleteBrandById(int id)
        {
            brandBLL.DeleteByID(id);
            return Ok(new { message = "Marka silindi", check = true });
          
        }
    }
}
