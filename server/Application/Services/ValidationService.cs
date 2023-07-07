using Domain.Interfaces;

namespace Application.Services
{
    public class ValidationService : IValidationService
    {
        public bool ValidatePagination(int? pageNumber, int? pageSize, out string errorMessage)
        {
            if ((pageNumber.HasValue && !pageSize.HasValue) || (!pageNumber.HasValue && pageSize.HasValue))
            {
                errorMessage = "Both 'pageNumber' and 'pageSize' parameters are required.";
                return false;
            }

            errorMessage = string.Empty;
            return true;
        }

        public bool ValidatePriceRange(int? minPrice, int? maxPrice, out string errorMessage)
        {
            if ((minPrice.HasValue && !maxPrice.HasValue) || (!minPrice.HasValue && maxPrice.HasValue))
            {
                errorMessage = "Both 'minPrice' and 'maxPrice' parameters are required.";
                return false;
            }

            errorMessage = string.Empty;
            return true;
        }

        public bool ValidatePriceValues(int? minPrice, int? maxPrice, int minPriceValue, int maxPriceValue, out string errorMessage)
        {
            if (minPrice.HasValue && minPrice.Value < minPriceValue)
            {
                errorMessage = $"The value of 'minPrice' must be greater than or equal to {minPriceValue}.";
                return false;
            }

            if (maxPrice.HasValue && maxPrice.Value > maxPriceValue)
            {
                errorMessage = $"The value of 'maxPrice' must be less than or equal to {maxPriceValue}.";
                return false;
            }

            errorMessage = string.Empty;
            return true;
        }

    }
}
