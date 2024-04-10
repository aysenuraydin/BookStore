using System;
using Microsoft.EntityFrameworkCore;
using BookStore.Business.Repositories;
using BookStore.Business;
using BookStore.Data;
using BookStore.Business.Abstract;
using BookStore.Entities;

namespace BookStore.Business.Concrete
{
    public class ProductImageRepository : Repository<ProductImage>, IProductImageRepository
    {
        public ProductImageRepository(BookStoreDbContext dbContext) : base(dbContext)
        {

        }

    }
}

#nullable disable

#nullable restore