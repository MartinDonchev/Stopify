using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Stopify.Services;
using Stopify.Services.Models;
using Stopify.Web.InputModels;

namespace Stopify.Web.Areas.Administration.Controllers
{
    public class ProductController : AdminController
    {
        private readonly IProductService productService;

        public ProductController(IProductService productService)
        {
            this.productService = productService;
        }

        [HttpGet]
        [Route("/Administration/Product/Type/Create")]
        public async Task<IActionResult> CreateType()
        {
            return this.View("Type/Create");
        }

        [HttpPost("/Administration/Product/Type/Create")]
        [Route("Type/Create")]
        public async Task<IActionResult> CreateType(ProductTypeCreateInputModel
            productTypeCreateInputModel)
        {
            ProductTypeServiceModel productTypeServiceModel = new ProductTypeServiceModel
            {
                Name = productTypeCreateInputModel.Name,
            };

            await this.productService.CreateProductType(productTypeServiceModel);

            return this.Redirect("/");
        }

        [HttpGet(Name = "Create")]
        public async Task<IActionResult> Create()
        {
            return this.View();
        }

        [HttpPost]

        public async Task<IActionResult> Create(ProductCreateInputModel productCreateInputModel)
        {
            ProductServiceModel productServiceModel = new ProductServiceModel
            {
                Name = productCreateInputModel.Name,
                Price = productCreateInputModel.Price,
                ManifacturedOn = productCreateInputModel.ManifacturedOn,
                ProductType = new ProductTypeServiceModel
                {
                    Name = productCreateInputModel.ProductType
                },
            };

            await this.productService.Create(productServiceModel);

            return this.Redirect("/");

        }
    }
}