using MediatR;
using Modules.Tasks.Application.Services;

namespace Modules.Tasks.Application.CreateTask
{
    internal class CreateTaskHandler : IRequestHandler<CreateTaskCommand, Guid>
    {
        private readonly ITaskRepository _repository;

        public CreateTaskHandler(ITaskRepository repository)
        {
            _repository = repository;
        }

        public async Task<Guid> Handle(CreateTaskCommand request, CancellationToken cancellationToken)
        {
            var task = new Domain.Task(request.Description);

            return await _repository.CreateTaskAsync(task);
        }
    }
}
