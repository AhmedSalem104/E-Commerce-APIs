using Microsoft.AspNetCore.Mvc;
using Services.Abstractions;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation
{
    // apis Controller
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController(IServiceManager serviceManager) : ControllerBase
    {

        // sort: nameasc [default]
        // sort: namedesc
        // sort: priceasc
        // sort: pricedesc
        

        [HttpGet] // GET: /api/Products
        public async Task<IActionResult> GetAllProduct([FromQuery]ProductSpecifiationsParameters specParams)
        {
            var result = await serviceManager.ProductService.GetAllProductAsync(specParams);
            if (result is null) return BadRequest(); // 400
            return Ok(result); // 200
        }

        [HttpGet("{id}")] // GET: /api/Products/1
        public async Task<IActionResult> GetProductById(int id)
        {
            var result = await serviceManager.ProductService.GetProductByIdAsync(id);
            if (result is null) return NotFound();

            return Ok(result);
        }

        [HttpGet("brands")] // GET: /api/Products/brands
        public async Task<IActionResult> GetAllBrands()
        {
            var result = await serviceManager.ProductService.GetAllBrandsAsync();
            if (result is null) return BadRequest();
            return Ok(result);
        }
     
        [HttpGet("types")] // GET: /api/Products/types
        public async Task<IActionResult> GetAllTypes()
        {
            var result = await serviceManager.ProductService.GetAllTypesAsync();
            if (result is null) return BadRequest();
            return Ok(result);
        }

    }
}
