using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.WebUI.Utils
{
    public class FileHelper
    {
        public static async Task<string> FileLoaderAsync(IFormFile formFile, string filePath = "/assets/Img/")
        {
            var fileName = "";

            if (formFile != null && formFile.Length > 0)
            {
                var exentions = Path.GetExtension(formFile.FileName);
                fileName = string.Format($"{Guid.NewGuid()}{exentions}");
                string directory = Directory.GetCurrentDirectory() + "/wwwroot" + filePath + fileName;
                using var stream = new FileStream(directory, FileMode.Create);
                await formFile.CopyToAsync(stream);
                return fileName;
            }

            return fileName;
        }
    }
}


