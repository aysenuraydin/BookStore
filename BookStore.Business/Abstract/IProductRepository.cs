using System;
using BookStore.Business.Repositories;
using BookStore.Entities;

namespace BookStore.Business.Abstract
{
    public interface IProductRepository : IRepository<Product>
    {

    }
}