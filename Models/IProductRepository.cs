using System;
using System.Linq;

namespace StoreFront.Models
    {
    public interface IProductRepository
        {
            IQueryable<Product> Products { get; }
        }
    }
