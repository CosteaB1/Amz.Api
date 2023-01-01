using Amz.Application.Commands;
using Amz.Application.Queries;
using Amz.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace Amz.Api.Controllers
{
    // to remove domain from projects
    [ApiController] // to check what it's doing
    [Route("[controller]")]
    public class ProductsController : BaseController<ProductsController> // to check difference between Controller and ControllerBase
    {

        [HttpGet]
        [Route("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var result = await Mediator.Send(new GetAllProductsQuery());
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Product product)
        {
            var command = new CreateProductCommand() { NewProduct = product };
            var result = await Mediator.Send(command);
            return Ok(result);
        }
    }
}
