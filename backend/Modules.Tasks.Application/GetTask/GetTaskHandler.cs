using MediatR;
using Modules.Tasks.Application.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Modules.Tasks.Application.GetTask
{
    public class GetTaskHandler : IRequestHandler<GetTaskQuery, Domain.Task>
    {
        private readonly ITaskRepository _taskRepository;

        public GetTaskHandler(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public async Task<Domain.Task> Handle(GetTaskQuery request, CancellationToken cancellationToken)
        {
            var task = await _taskRepository.GetTaskByIdAsync(request.Id);

            return task;
        }
    }
}
