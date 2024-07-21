using System;
using System.Collections.Generic;

namespace TaskManagerAnswer
{
    public class TaskManager
    {
        public TaskManager()
        {
            // Empty for now
        }
    }

    public class Task
    {
        public int Id { get; }
        public string Description { get; }
        public DateTime? DueDate { get; }
        public bool Complete { get; set; }

        public Task(int id, string description, DateTime? dueDate)
        {
            Id = id;
            Description = description;
            DueDate = dueDate;
            Complete = false;
        }
    }
}