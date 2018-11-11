using System;
using System.Linq;
using System.Collections.Generic;

namespace StoreFront.Models
    {
    public class EFProductRepository : IProductRepository
        {
            private ApplicationDbContext context;

            public EFProductRepository(ApplicationDbContext ctx)
                {
                    context = ctx;
                }
            public IQueryable<Product> Products => context.Products;
        }
    }
