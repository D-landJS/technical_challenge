using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public ProductRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        async Task<Product> IProductRepository.Update(Product entity)
        {
            entity.UpdateDate = DateTime.Now;

            _dbContext.Update(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<int> GetTotalCount()
        {
            return await _dbContext.Products.CountAsync();
        }

        public async Task<IEnumerable<Product>> GetOrderedProducts(string? orderBy)
        {
            IQueryable<Product> query = _dbContext.Products;

            switch (orderBy)
            {
                case "priceAsc":
                    query = query.OrderBy(p => p.Price);
                    break;
                case "priceDesc":
                    query = query.OrderByDescending(p => p.Price);
                    break;
                default:
                    query = query.OrderBy(p => p.Id);
                    break;
            }

            return await query.ToListAsync();
        }

        public async Task<int> GetMinPrice()
        {
            return await _dbContext.Products.MinAsync(p => p.Price);
        }

        public async Task<int> GetMaxPrice()
        {
            return await _dbContext.Products.MaxAsync(p => p.Price);
        }

    }
}
