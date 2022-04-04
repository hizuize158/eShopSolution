using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.ViewModels.Catalogs.ProductImages
{
    public class ProductImageUpdateRequest
    {
        public int Id { get; set; }
        public string Caption { set; get; }
        public bool IsDefault { set; get; }
        public int SortOrder { set; get; }
        public IFormFile ImageFile { set; get; }
    }
}
