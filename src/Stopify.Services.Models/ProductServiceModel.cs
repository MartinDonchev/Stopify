using System;

namespace Stopify.Services.Models
{
    public class ProductServiceModel
    {
        public string Name { get; set; }

        public int ProductTypeId { get; set; }

        public ProductTypeServiceModel ProductType { get; set; }

        public decimal Price { get; set; }

        public string Picture { get; set; }

        public DateTime ManifacturedOn { get; set; }
    }
}
