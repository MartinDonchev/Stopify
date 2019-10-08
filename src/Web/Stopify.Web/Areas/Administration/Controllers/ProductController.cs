using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Stopify.Services.Models;
using Stopify.Web.InputModels;

namespace Stopify.Web.Areas.Administration.Controllers
{
    public class ProductController : Controller
    {
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
                }
            };
            return this.Redirect("/");

        }
    }
}