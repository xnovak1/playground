using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Modules.Tasks.Application.UpdateTask
{
    public class UpdateTaskCommand : IRequest
    {
        public Guid Id { get; set; }
        public string? Description { get; set; }
        public bool? IsCompleted { get; set; }
    }
}
