using Amz.Api.ViewModels.Product;
using Amz.Application.Commands.Products;
using Amz.Application.Queries.Products;
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
        public async Task<IActionResult> Create([FromBody] CreateProductViewModel productViewModel)
        {
            var command = Mapper.Map<CreateProductCommand>(productViewModel);
            try
            {
                var respone = await Mediator.Send(command);
                var result = Mapper.Map<CreateProductViewModel>(respone);
                return Ok(result);

            }
            catch (Exception ex)
            {
                Logger.LogError(ex.Message);
                return StatusCode(500);
            }
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            try
            {
                var productToDeleteCmd = new DeleteProductCommand
                {
                    Id = id,
                };
                var deletedId = await Mediator.Send(productToDeleteCmd);
                return Ok(deletedId);
            }
            catch (Exception ex)
            {
                Logger.LogError(ex.Message);
                return StatusCode(500);
            }

        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update([FromRoute] Guid id, UpdateProductViewModel productUpdate)
        {
            var command = Mapper.Map<UpdateProductCommand>(productUpdate);
            command.Id = id;
            try
            {
                var respone = await Mediator.Send(command);
                var result = Mapper.Map<UpdateProductViewModel>(respone);
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
