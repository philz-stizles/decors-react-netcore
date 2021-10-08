﻿using MediatR;
using Microsoft.AspNetCore.Mvc;
// using Microsoft.Extensions.DependencyInjection;

namespace Decors.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class BaseController : ControllerBase
    {
        protected IMediator Mediator;
        // protected IMediator Mediator => _mediator ?? (_mediator = HttpContext.RequestServices.GetService<IMediator>());

        public BaseController(IMediator mediator)
        {
            Mediator = mediator;
        }
    }
}
