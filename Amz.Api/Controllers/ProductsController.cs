using Amz.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace Amz.Api.Controllers
{
    [ApiController] // to check what it's doing
    [Route("[controller]")]
    public class ProductsController : Controller // to check difference between Controller and ControllerBase
    {

        //[HttpGet] // if we do not specify by default is Get
        //[Route("{id}")]
        //public IActionResult GetById(int id)
        //{
        //    var product = new Product { Id = id, Name = "TestName" };
        //    return Ok(product);
        //}
    }
}
