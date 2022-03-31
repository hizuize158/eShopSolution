using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Entities
{
    public class ProductImage
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string ImagePath { get; set; }
        public string Caption { set; get; }
        public bool IsDefault { set; get; }
        public DateTime DateCreated { set; get; }
        public int SortOrder { set; get; }
        public int FileSize { set; get; }
        public Product Product { set; get; }

    }
}
