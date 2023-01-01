using Amz.Api.ViewModels.Product;
using Amz.Application.Commands;
using Amz.Application.Queries;
using Microsoft.AspNetCore.Mvc;

namespace Amz.Api.Controllers
{
    // to remove domain from projects
    [ApiController] // to check what it's doing
    [Route("[controller]")]
    public class ProductsController : BaseController<ProductsController>
    {

        [HttpGet]
        [Route("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            Logger.LogInformation("Get All products");
            var result = await Mediator.Send(new GetAllProductsQuery());
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] ProductCreateViewModel productViewModel)
        {
            var command = Mapper.Map<CreateProductCommand>(productViewModel);
            try
            {
                var result = await Mediator.Send(command);
                return Ok(result);

            }
            catch (Exception ex)
            {

                Logger.LogError(ex.Message);
                return StatusCode(500);
            }
        }
    }
}
