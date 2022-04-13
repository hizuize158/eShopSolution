using eShopSolution.ViewModels.Catalog.Products;
using eShopSolution.ViewModels.Catalogs.ProductImages;
using eShopSolution.ViewModels.Catalogs.Products;
using eShopSolution.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eShopSolution.Application.Catalogs.Products
{
    public interface IProductService
    {
        Task<int> Create(ProductCreateRequest request);
        Task<int> Update(ProductUpdateRequest request);
        Task<bool> UpdatePrice(int productId, decimal newPrice);
        Task<bool> UpdateStock(int productId, int addedQuantity);

        Task AddViewcount(int productId);
        Task<int> Delete(int productId);
        Task<ProductViewModel> GetById(int productId, string languageId);
        Task<PagedResult<ProductViewModel>> GetAllPaging(GetManageProductPagingRequest request);

        Task<int> AddImage(int productId, ProductImageCreateRequest request);
        Task<int> RemoveImage(int imageId);
        Task<int> UpdateImage(int imageId, ProductImageUpdateRequest request);
        Task<List<ProductImageViewModel>> GetListImages(int productId);
        Task<ProductImageViewModel> GetImageById(int imageId);

        Task<PagedResult<ProductViewModel>> GetAllByCategoryId(string languageId, GetPublicProductPagingRequest request);

    }
}
