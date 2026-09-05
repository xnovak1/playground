using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Modules.Tasks.Application.GetTasks
{
    public class GetTasksQuery : IRequest<IEnumerable<Domain.Task>>
    {
    }
}
