namespace Stopify.Services
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using Stopify.Services.Models;
    using Stopify.Data;

    public class ProductService : IProductService
    {
        private readonly StopifyDbContext context;
        public bool Create(ProductServiceModel productServiceModel)
        {
            throw new NotImplementedException();
        }
    }
}
