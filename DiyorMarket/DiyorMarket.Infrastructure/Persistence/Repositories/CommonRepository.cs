﻿using DiyorMarket.Domain.Enterfaces.Repositories;

namespace DiyorMarket.Infrastructure.Persistence.Repositories
{
    public class CommonRepository : ICommonRepository
    {
        private readonly DiyorMarketDbContext _context;

        private ICategoryRepository _category;
        public ICategoryRepository Category
        {
            get
            {
                _category ??= new CategoryRepository(_context);

                return _category;
            }
        }

        private IProductRepository _product;
        public IProductRepository Product
        {
            get
            {
                _product ??= new ProductRepository(_context);

                return _product;
            }
        }
        public CommonRepository(DiyorMarketDbContext context)
        {
            _context = context;

            _category = new CategoryRepository(context);
            _product = new ProductRepository(context);
        }

        public Task<int> SaveChangesAsync()
        {
            return _context.SaveChangesAsync();
        }

        public int SaveChanges() => _context.SaveChanges();
    }
}
