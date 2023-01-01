using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Amz.Api.Controllers
{
    public class BaseController<T>: ControllerBase where T : BaseController<T> // to check difference between Controller and ControllerBase
    {
        private ILogger<T>? _logger;
        private IMediator? _mediator;
        private IMapper? _mapper;


        protected ILogger<T> Logger => _logger ??= HttpContext.RequestServices.GetRequiredService<ILogger<T>>();
        protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetRequiredService<IMediator>();
        protected IMapper Mapper => _mapper ??= HttpContext.RequestServices.GetRequiredService<IMapper>();
    }
}
