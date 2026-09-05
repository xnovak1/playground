using MediatR;
using Modules.Tasks.Application.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Modules.Tasks.Application.DeleteTask
{
    public class DeleteTaskHandler : IRequestHandler<DeleteTaskCommand>
    {
        private readonly ITaskRepository _repository;

        public DeleteTaskHandler(ITaskRepository repository)
        {
            _repository = repository;
        }

        public async Task Handle(DeleteTaskCommand request, CancellationToken cancellationToken)
        {
            await _repository.DeleteTaskAsync(request.Id);
        }
    }
}
