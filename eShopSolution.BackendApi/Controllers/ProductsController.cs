﻿using eShopSolution.Application.Catalog.Products;
using eShopSolution.Data.Entities;
using eShopSolution.ViewModels.Catalog.ProductImages;
using eShopSolution.ViewModels.Catalog.Products;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eShopSolution.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController] 
    public class ProductsController : ControllerBase
    {
        private readonly IPublicProductService _publicProductService;
        private readonly IManageProductService _manageProductService;

        public ProductsController(IPublicProductService publicProductService,
            IManageProductService manageProductService)
        {
            _publicProductService = publicProductService;
            _manageProductService = manageProductService;
        }

        //public
        //http://localhost:port/products?pageIndex=1&pageSize=10&categoryId
        [HttpGet("{languageId}")]
        public async Task<IActionResult> GetAllPaging(string languageId, [FromQuery] GetPublicProductPagingRequest request)
        {
            var products = await _publicProductService.GetAllByCategoryId(languageId,request);
            return Ok(products);
        }

        //manage
        //http://localhost:port/products/1
        [HttpGet("{productId}/{languageId}")]
        public async Task<IActionResult> GetById(int productId, string languageId)
        {
            var product = await _manageProductService.GetById(productId, languageId);
            if (product == null)
                return BadRequest("Cannot find product");
            return Ok(product);
        }
        //Create
        [HttpPost]
        public async Task<IActionResult> Create([FromForm]ProductCreateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var productId = await _manageProductService.Create(request);
            if (productId == 0)
                return BadRequest();
            var product= await _manageProductService.GetById(productId, request.LanguageId);
            return CreatedAtAction(nameof(GetById), new {id = productId}, product);
        }
        //Update
        [HttpPut]
        public async Task<IActionResult> Update([FromForm] ProductUpdateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var affectedResult = await _manageProductService.Update(request);
            if (affectedResult == 0)
                return BadRequest();
            return Ok();
        }
        //Delete
        [HttpDelete("productId")]
        public async Task<IActionResult> Delete(int productId)
        {
            var affectedResult = await _manageProductService.Delete(productId);
            if (affectedResult == 0)
                return BadRequest();
            return Ok();
        }
        //UpdatePrice
        [HttpPatch("{productId}/{newPrice}")]
        public async Task<IActionResult> UpdatePrice(int productId, decimal newPrice)
        {
            var isSuccessful = await _manageProductService.UpdatePrice(productId, newPrice);
            if (isSuccessful)
                return Ok();
            return BadRequest();
        }
        //Image
        [HttpPost("{productId}/images")]
        public async Task<IActionResult> CreateImage(int productId,[FromForm] ProductImageCreateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            
            var imageId = await _manageProductService.AddImage(productId,request);
            if (imageId == 0)
                return BadRequest();
            var product = await _manageProductService.GetImageById(imageId);
            return CreatedAtAction(nameof(GetImageById), new { id = imageId }, imageId);
        }

        [HttpPut("{productId}/images/{imageId}")]
        public async Task<IActionResult> UpdateImage(int imageId, [FromForm] ProductImageUpdateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = await _manageProductService.UpdateImage(imageId, request);
            if (result == 0)
                return BadRequest();
            return Ok();
        }

        [HttpDelete("{productId}/images/{imageId}")]
        public async Task<IActionResult> DeleteImage(int imageId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = await _manageProductService.RemoveImage(imageId);
            if (result == 0)
                return BadRequest();
            return Ok();
        }

        [HttpGet("{productId}/images/{imageId}")]
        public async Task<IActionResult> GetImageById(int productId, int imageId)
        {
            var image = await _manageProductService.GetImageById(imageId);
            if (image == null)
                return BadRequest("Cannot find image");
            return Ok(image);
        }
    }
}
