using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IValidationService
    {
        bool ValidatePagination(int? pageNumber, int? pageSize, out string errorMessage);
        bool ValidatePriceRange(int? minPrice, int? maxPrice, out string errorMessage);
        bool ValidatePriceValues(int? minPrice, int? maxPrice, int minPriceValue, int maxPriceValue, out string errorMessage);

    }
}
