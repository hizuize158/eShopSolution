using eShopSolution.ViewModels.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Application.Catalogs.Products
{
    public class GetPublicProductPagingRequest : PagingRequestBase
    {
        public string languageId { get; set; }
        public int? CategoryId { get; set; }
    }
}
