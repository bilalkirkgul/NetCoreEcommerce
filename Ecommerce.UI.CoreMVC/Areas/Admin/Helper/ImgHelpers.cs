using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.UI.CoreMVC.Areas.Admin.Helper
{
    public static class ImgHelpers
    {

        [Obsolete]
        public static string GetImageUrl(IFormFile file, IHostingEnvironment environment)
        {
            string resimler = Path.Combine(environment.WebRootPath, "assets/productImg");
            string newName = string.Empty;
            if (file != null)
            {
                string dosya = file.FileName;
                string[] dosyaArray = dosya.Split('.');
                newName = Guid.NewGuid().ToString() + "." + dosyaArray[dosyaArray.Length - 1];

                using (var fileStream = new FileStream(Path.Combine(resimler, newName), FileMode.Create))
                {
                    file.CopyTo(fileStream);
                }
            }
            return  "../../assets/productImg/" + newName;
        }


    }
}
