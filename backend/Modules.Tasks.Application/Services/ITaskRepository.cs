using System;
using System.Collections.Generic;
using System.Text;

namespace Modules.Tasks.Application.Services
{
    public interface ITaskRepository
    {
        public Task<Domain.Task?> GetTaskByIdAsync(Guid taskId);
        public Task<IEnumerable<Domain.Task>> GetTasksAsync();
        public Task<Guid> CreateTaskAsync(Domain.Task task);
        public Task UpdateTaskAsync(Domain.Task task);
        public Task DeleteTaskAsync(Guid taskId);
    }
}
