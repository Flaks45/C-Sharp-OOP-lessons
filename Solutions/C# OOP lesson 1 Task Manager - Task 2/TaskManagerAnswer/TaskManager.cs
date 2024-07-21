using System;
using System.Collections.Generic;

namespace TaskManagerAnswer
{
    public class TaskManager
    {
        private List<Task> tasks;
        private int nextTaskId;

        public TaskManager()
        {
            tasks = new List<Task>();
            nextTaskId = 1;
        }

        public void AddTask(string description, DateTime? dueDate)
        {
            Task newTask = new Task(nextTaskId, description, dueDate);
            tasks.Add(newTask);
            Console.WriteLine($"Task {nextTaskId} has been added.");
            
            nextTaskId++;
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