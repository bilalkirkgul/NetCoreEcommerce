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
    public class SupplierController : ControllerBase
    {

        ISupplierBLL supplierBLL;
        public SupplierController(ISupplierBLL suppBll)
        {
            supplierBLL = suppBll;
        }

     
        List<SupplierDTO> SupplierDTOList(ICollection<Supplier> supplierslist)
        {
            List<SupplierDTO> suppliers = new List<SupplierDTO>();
            foreach (Supplier item in supplierslist)
            {
                suppliers.Add(new SupplierDTO
                {
                    SupplierID = item.ID,
                    CompanyName = item.CompanyName,
                    Address = item.Address,
                    PhoneNummer = item.PhoneNummer,
                    City = item.City,
                    Country = item.Country,
                    IsActive=item.IsActive
                });
            }
            return suppliers;
        }

        void NameControl(string CompanyName)
        {
            ICollection<Supplier> suppliers = supplierBLL.GetAll();
            foreach (Supplier item in suppliers)
            {
                if (item.CompanyName == CompanyName)
                {
                    throw new Exception($"{item.CompanyName} kayıtlarda böyle bu isimde kategori mevcut ");
                }
            }
        }


        //ajax ile tüm tedarikçileri basmak için bu methodu oluşturdum method içerisinde bll'de kullanmış olduğum getall methodu kullanıldığı için tekrardan gidilip bll katmanına tanımlama yapmadım..
        public IActionResult GetSuppliers()
        {
            List<SupplierDTO> suppliers = SupplierDTOList(supplierBLL.GetSuppliers());
            return Ok(suppliers);
        }
        public IActionResult GetSuppliersActive()
        {
            List<SupplierDTO> suppliers = SupplierDTOList(supplierBLL.GetSuppliers());
            return Ok(suppliers);
        }

        public IActionResult GetSuppliersFull()//adminde aktif olmayanalrıda görmek istiyorum
        {
            List<SupplierDTO> suppliers = SupplierDTOList(supplierBLL.GetAll());
            return Ok(suppliers);
        }


        [HttpGet("{id}")]
        public IActionResult GetSupplierById(int id)
        {
            Supplier supplier = supplierBLL.Get(id);
            SupplierDTO supplierDTO = new SupplierDTO();
            supplierDTO.SupplierID = supplier.ID;
            supplierDTO.CompanyName = supplier.CompanyName;
            supplierDTO.Address = supplier.Address;
            supplierDTO.City = supplier.City;
            supplierDTO.Country = supplier.Country;
            supplierDTO.PhoneNummer = supplier.PhoneNummer;
            return Ok(supplierDTO);

        }


        [HttpPost]
        public IActionResult UpdateSupplier([FromBody] SupplierDTO itemDTO)
        {
            try
            {
                Supplier supplier = supplierBLL.Get(itemDTO.SupplierID);
                supplier.CompanyName = itemDTO.CompanyName;
                supplier.Address = itemDTO.Address;
                supplier.City = itemDTO.City;
                supplier.Country = itemDTO.Country;
                supplier.PhoneNummer = itemDTO.PhoneNummer;
                supplier.IsActive = true;
                supplierBLL.Update(supplier);
                return Ok(new { message = "Tedarikçi güncellendi", check = true });
            }
            catch (Exception ex)
            {

                return Ok(new { message = ex.Message, check = false });
            }
        }

        [HttpPost]
        public IActionResult AddSupplier([FromBody] SupplierDTO itemDTO)
        {
            try
            {
                NameControl(itemDTO.CompanyName);
                Supplier supplier = new Supplier();

                supplier.ID = itemDTO.SupplierID;
                supplier.CompanyName = itemDTO.CompanyName;
                supplier.Address = itemDTO.Address;
                supplier.City = itemDTO.City;
                supplier.Country = itemDTO.Country;
                supplier.PhoneNummer = itemDTO.PhoneNummer;
                supplierBLL.Insert(supplier);
                return Ok(new { message = "Tedarikçi kaydedildi", check = true });

            }
            catch (Exception ex)
            {
                return Ok(new { message = ex.Message, check = false });
            }


        }

        [HttpGet("{id}")]
        public IActionResult DeleteSupplierById(int id)
        {
            supplierBLL.DeleteByID(id);
            return Ok(new { message = "Tedarikçi silindi", check = true });
           
        }


    }
}
