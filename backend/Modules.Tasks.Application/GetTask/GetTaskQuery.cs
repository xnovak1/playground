using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Modules.Tasks.Application.GetTask
{
    public class GetTaskQuery : IRequest<Domain.Task>
    {
        public Guid Id { get; set; }
    }
}
