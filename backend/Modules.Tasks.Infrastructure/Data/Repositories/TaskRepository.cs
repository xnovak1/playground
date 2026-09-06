using Microsoft.EntityFrameworkCore;
using Modules.Tasks.Application.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Modules.Tasks.Infrastructure.Data.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        private readonly TasksDbContext _context;

        public TaskRepository(TasksDbContext context)
        {
            _context = context;
        }

        public async Task<Guid> CreateTaskAsync(Domain.Task task)
        {
            _context.Tasks.Add(task);

            await _context.SaveChangesAsync();

            return task.Id;
        }

        public async Task DeleteTaskAsync(Guid taskId)
        {
            await _context.Tasks
                .Where(task => task.Id == taskId)
                .ExecuteDeleteAsync();
        }

        public async Task<Domain.Task?> GetTaskByIdAsync(Guid taskId)
        {
            var task = await _context.Tasks
                .AsNoTracking()
                .SingleOrDefaultAsync(task => task.Id == taskId);

            return task;
        }

        public async Task<IEnumerable<Domain.Task>> GetTasksAsync()
        {
            var tasks = await _context.Tasks
                .AsNoTracking()
                .ToListAsync();

            return tasks;
        }

        public async Task UpdateTaskAsync(Domain.Task task)
        {
            _context.Tasks.Update(task);

            await _context.SaveChangesAsync();
        }
    }
}
