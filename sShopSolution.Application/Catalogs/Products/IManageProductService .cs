using eShopSolution.Application.Catalogs.Products.Dtos;
using eShopSolution.Application.Catalogs.Products.Dtos.Manage;
using eShopSolution.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Application.Catalogs.Products
{
    public interface IManageProductService
    {
        Task<int> CreateProduct(ProductCreateRequest request);
        Task<int> Update(ProductUpdateRequest request);
        Task<bool> UpdatePrice(int productId,decimal newPrice);
        Task<bool> UpdateStock(int productId, int addedQuantity);

        Task AddViewcount(int productId);
        Task<int> Delete(int productId);
        Task<PagedResult<ProductViewModel>> GetAllPaging(GetProductPagingRequest request);

    }
}
