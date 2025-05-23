﻿using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Abstractions
{
    public interface IProductService
    {
        // Get All Products
        Task<PaginationResponse<ProductResultDto>> GetAllProductAsync(ProductSpecifiationsParameters specParams);

        // Get Product By Id
        Task<ProductResultDto?> GetProductByIdAsync(int id);

        // Get All Brands
        Task<IEnumerable<BrandResultDto>> GetAllBrandsAsync();

        // Get All Types
        Task<IEnumerable<TypeResultDto>> GetAllTypesAsync();

    }
}
