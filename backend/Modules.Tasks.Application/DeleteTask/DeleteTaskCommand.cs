using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Modules.Tasks.Application.DeleteTask
{
    public class DeleteTaskCommand : IRequest
    {
        public Guid Id {  get; set; }
    }
}
