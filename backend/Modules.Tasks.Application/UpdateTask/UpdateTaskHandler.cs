using MediatR;
using Modules.Tasks.Application.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Modules.Tasks.Application.UpdateTask
{
    internal class UpdateTaskHandler : IRequestHandler<UpdateTaskCommand>
    {
        private readonly ITaskRepository _repository;

        public UpdateTaskHandler(ITaskRepository repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateTaskCommand request, CancellationToken cancellationToken)
        {
            var task = await _repository.GetTaskByIdAsync(request.Id);

            if (task is null)
            {
                return;
            }

            if (request.Description is not null)
            {
                task.UpdateDescription(request.Description);
            }

            if (request.IsCompleted.HasValue)
            {
                task.SetCompletion(request.IsCompleted.Value);
            }

            await _repository.UpdateTaskAsync(task);
        }
    }
}
