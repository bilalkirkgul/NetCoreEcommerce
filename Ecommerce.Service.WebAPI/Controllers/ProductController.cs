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
    public class ProductController : ControllerBase
    {
        IProductBLL productBLL;
        public ProductController(IProductBLL pBLL)
        {
            productBLL = pBLL;
        }

        //modelde yer alan productı productDTO listesine çevirdim..
        List<ProductDTO> ProductDTOList(ICollection<Product> listProduct)
        {
            List<ProductDTO> products = new List<ProductDTO>();
            foreach (Product item in listProduct)
            {
                products.Add(new ProductDTO()
                {
                    ProductID=item.ID,
                    ProductName=item.ProductName,
                    ProductImgUrl=item.ProductImgUrl,
                    Description=item.Description,
                    Stock=item.Stock,
                    Price=item.Price,
                    BrandName=item.Brand.BrandName,
                    CategoryID=item.CategoryID,
                    BrandID = item.BrandID,
                    SupplierID = item.SupplierID,
                    CategoryName =item.Category.CategoryName,
                    CompanyName=item.Supplier.CompanyName,
                    IsActive=item.IsActive,
                    Continued=item.Continued,
                    DisCounted=item.DisCounted,
                    CreatedDate=item.CreatedDate
                   

                });
            }
            return products;
        }

        //modelden dto içerisine aldığımız tüm ürünleri ajaxla listelemek için oluşturulan IActionResult. Burada bll içerisinde tanımlı olmayan method oluşturup kullandığım için bll servisine gidip soyut ve somut nesnelerin içerisine oluşturdum..
        public IActionResult GetProducts()
        {           
            List<ProductDTO> products = ProductDTOList(productBLL.GetProducts());
            return Ok(products);
        }

        public IActionResult GetProductActive()
        {
            List<ProductDTO> products = ProductDTOList(productBLL.GetProductActive());
            return Ok(products);
        }


        //ID numarasına göre ürün yakaladım tüm bilgilerini aldım ve bunu home detail sayfasında get ile ajax ile bastım. method içerisinde get ile tek nesne yakaladım get bll de tanımlı olduğu için methodu bll'e aktarmadım.

        [HttpGet("{id}")]
        public IActionResult GetProductById(int id)
        {
            Product product = productBLL.Get(id);
            ProductDTO productDTO = new ProductDTO();
            productDTO.ProductID = product.ID;
            productDTO.ProductName = product.ProductName;
            productDTO.ProductImgUrl = product.ProductImgUrl;
            productDTO.Description = product.Description;
            productDTO.Stock = product.Stock;
            productDTO.Price = product.Price;            
            productDTO.BrandName = product.Brand.BrandName;          
            productDTO.CategoryName = product.Category.CategoryName;
            productDTO.CompanyName = product.Supplier.CompanyName;

            return Ok(productDTO);
        }


        [HttpGet("{id}")]//id numarasına göre marka kesinlikle dtoya çevrilip client tarafına aktarılması lazım
        public IActionResult GetProductListBrand(int id)
        {
            List<Product> product = productBLL.GetProductByBrand(id).ToList();

            return Ok(ProductDTOList(product));
        }
        [HttpGet("{id}")]//id numarasına göre kategori kesinlikle dtoya çevrilip client tarafına aktarılması lazım
        public IActionResult GetByCategory(int id)
        {
            List<Product> products = productBLL.GetByCategory(id).ToList();
            return Ok(ProductDTOList(products));
        }

        [HttpGet("{name}")]
        public IActionResult GetProductSearch(string name)
        {
            List<Product> product = productBLL.ProductGetSearch(name).ToList();
           return Ok(ProductDTOList(product));
        }

        [HttpGet("{id}")]
        public IActionResult GetCartItemById(int id)
        {
            Product product = productBLL.GetCartItem(id);
            CartDTO cartDTO = new CartDTO();
            cartDTO.ID = product.ID;
            cartDTO.Name = product.ProductName;
            cartDTO.Price = product.Price;
            cartDTO.BrandName = product.Brand.BrandName;
            cartDTO.Description = product.Description;
            cartDTO.ProductImgUrl = product.ProductImgUrl;
            return Ok(cartDTO);

        }

      

        [HttpPost]
        public IActionResult AddProduct([FromBody] ProductDTO product)
        {
            try
            {
                Product newproduct = new Product();
                newproduct.ID = product.ProductID;
                newproduct.ProductName = product.ProductName;
                newproduct.ProductImgUrl = product.ProductImgUrl;
                newproduct.Description = product.Description;
                newproduct.Stock = product.Stock;
                newproduct.Price = product.Price;
                newproduct.CategoryID = product.CategoryID;
                newproduct.SupplierID = product.SupplierID;
                newproduct.BrandID = product.BrandID;
                productBLL.Insert(newproduct);
                return Ok(new { message = "Ürün ekleme işlemi gerçekleşti", check = true });
            }
            catch (Exception ex)
            {
                return Ok(new { message = ex.Message, check = false });
            }
        }


        [HttpPost]
        public IActionResult UpdateProduct([FromBody] ProductDTO productDTO)
        {
            try
            {
                Product product = productBLL.Get(productDTO.ProductID);
                product.ID = productDTO.ProductID;
                product.ProductName = productDTO.ProductName;
                product.ProductImgUrl = productDTO.ProductImgUrl;
                product.Description = productDTO.Description;
                product.Stock = productDTO.Stock;
                product.Price = productDTO.Price;
                product.CategoryID = productDTO.CategoryID;
                product.SupplierID = productDTO.SupplierID;
                product.BrandID = productDTO.BrandID;
                productBLL.Update(product);
                return Ok(new { message = "Ürün güncellendi", check = true });

            }
            catch (Exception ex)
            {

                return Ok(new { message = ex.Message, check = false });
            }
        }


        [HttpGet("{id}")]
        public IActionResult DeleteProductById(int id)
        {
            productBLL.DeleteByID(id);
            return Ok(new { message = "Ürün silindi", check = true });
        }

    }
}
