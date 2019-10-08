using Stopify.Services.Models;
using Stopify.Web.InputModels;

namespace Stopify.Services
{
    public interface IProductService
    {
        bool Create(ProductServiceModel productServiceModel);
    }
}
