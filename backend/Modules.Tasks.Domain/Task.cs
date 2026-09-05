using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Modules.Tasks.Domain
{
    public class Task
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public bool IsCompleted { get; set; }

        public Task(string description)
        {
            Id = Guid.NewGuid();
            Description = description;
            IsCompleted = false;
        }

        public void SetCompletion(bool completed)
        {
            IsCompleted = completed;
        }

        public void UpdateDescription(string description)
        {
            Description = description;
        }
    }
}
