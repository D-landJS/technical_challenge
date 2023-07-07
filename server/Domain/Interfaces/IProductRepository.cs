
using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IProductRepository : IRepository<Product>
    {
        Task<Product> Update(Product entity);

        Task<int> GetTotalCount();
        Task<IEnumerable<Product>> GetOrderedProducts(string? orderBy);
        Task<int> GetMinPrice();
        Task<int> GetMaxPrice();

    }
}
