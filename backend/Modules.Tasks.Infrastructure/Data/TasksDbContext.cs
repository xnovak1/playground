using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Modules.Tasks.Infrastructure.Data
{
    public class TasksDbContext(DbContextOptions<TasksDbContext> options) : DbContext(options)
    {
        public DbSet<Domain.Task> Tasks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var builder = modelBuilder.Entity<Domain.Task>();

            builder.Property(entity => entity.Id)
                .ValueGeneratedNever()
                .IsRequired();
        }
    }
}
