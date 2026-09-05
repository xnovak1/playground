using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Modules.Tasks.Application.CreateTask
{
    internal class CreateTaskCommand : IRequest<Guid>
    {
        public string? Description {  get; set; }
    }
}
