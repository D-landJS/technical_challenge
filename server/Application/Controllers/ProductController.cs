using Application.Services;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Application.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepo;
        protected APIResponse _apiResponse;
        private readonly IValidationService _validationService;

        public ProductController(IProductRepository productRepo, IValidationService validationService)
        {
            _productRepo = productRepo;
            _validationService = validationService;
            _apiResponse = new();
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<APIResponse>> GetProducts(int? pageNumber = null, int? pageSize = null, string? orderBy = null, int? minPrice = null, int? maxPrice = null)
        {
            try
            {
                var validationResult = await ValidateRequest(pageNumber, pageSize, minPrice, maxPrice);
                if (validationResult != null)
                {
                    return validationResult;
                }

                IEnumerable<Product> productList;
                if (!string.IsNullOrEmpty(orderBy))
                {
                    productList = await _productRepo.GetOrderedProducts(orderBy);
                }
                else
                {
                    productList = await _productRepo.GetAll();
                }

                if (minPrice.HasValue && maxPrice.HasValue)
                {
                    productList = productList.Where(p => p.Price >= minPrice.Value && p.Price <= maxPrice.Value);
                }

                pageNumber ??= 1;
                pageSize ??= 10;

                int totalCount = productList.Count();

                int totalPages = (int)Math.Ceiling((double)totalCount / pageSize.Value);

                if (pageNumber.HasValue && pageSize.HasValue)
                {
                    productList = productList.Skip((pageNumber.Value - 1) * pageSize.Value).Take(pageSize.Value);
                }

                int minPriceValue = await _productRepo.GetMinPrice();
                int maxPriceValue = await _productRepo.GetMaxPrice();

                _apiResponse.Result = new
                {
                    Products = productList,
                    TotalCount = totalCount,
                    TotalPages = totalPages,
                    PageNumber = pageNumber ,
                    PageSize = pageSize,
                    MinPrice = minPriceValue,
                    MaxPrice = maxPriceValue
                };
                _apiResponse.StatusCode = HttpStatusCode.OK;

                return Ok(_apiResponse);
            }
            catch (Exception ex)
            {
                _apiResponse.IsSuccessfull = false;
                _apiResponse.ErrorMessages = new List<string> { ex.ToString() };
            }

            return _apiResponse;
        }

        private async Task<ActionResult<APIResponse>?> ValidateRequest(int? pageNumber, int? pageSize, int? minPrice, int? maxPrice)
        {
            if (!_validationService.ValidatePagination(pageNumber, pageSize, out string paginationErrorMessage))
            {
                return BadRequest(new APIResponse
                {
                    StatusCode = HttpStatusCode.NotFound,
                    IsSuccessfull = false,
                    ErrorMessages = new List<string> { paginationErrorMessage }
                });
            }

            if (!_validationService.ValidatePriceRange(minPrice, maxPrice, out string priceRangeErrorMessage))
            {
                return BadRequest(new APIResponse
                {
                    StatusCode = HttpStatusCode.NotFound,
                    IsSuccessfull = false,
                    ErrorMessages = new List<string> { priceRangeErrorMessage }
                });
            }

            int minPriceValue = await _productRepo.GetMinPrice();
            int maxPriceValue = await _productRepo.GetMaxPrice();

            if (!_validationService.ValidatePriceValues(minPrice, maxPrice, minPriceValue, maxPriceValue, out string priceErrorMessage))
            {
                return BadRequest(new APIResponse
                {
                    StatusCode = HttpStatusCode.NotFound,
                    IsSuccessfull = false,
                    ErrorMessages = new List<string> { priceErrorMessage }
                });
            }

            return null;
        }



    }
}