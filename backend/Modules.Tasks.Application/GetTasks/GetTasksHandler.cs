using MediatR;
using Modules.Tasks.Application.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Modules.Tasks.Application.GetTasks
{
    public class GetTasksHandler : IRequestHandler<GetTasksQuery, IEnumerable<Domain.Task>>
    {
        private readonly ITaskRepository _repository;

        public GetTasksHandler(ITaskRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Domain.Task>> Handle(GetTasksQuery request, CancellationToken token)
        {
            var tasks = await _repository.GetTasksAsync();

            return tasks;
        }
    }
}
