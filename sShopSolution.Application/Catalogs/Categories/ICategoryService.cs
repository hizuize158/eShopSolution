﻿using eShopSolution.ViewModels.Catalog.Categories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Application.Catalogs.Categories
{
    public interface ICategoryService
    {
        Task<List<CategoryVm>> GetAll();
    }
}