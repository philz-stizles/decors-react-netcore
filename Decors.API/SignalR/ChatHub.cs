﻿using MediatR;
using Microsoft.AspNetCore.SignalR;

namespace Decors.API.SignalR
{
    public class ChatHub: Hub
    {
        private readonly IMediator _mediator;

        public ChatHub(IMediator mediator)
        {
            _mediator = mediator;
        }
    }
}
