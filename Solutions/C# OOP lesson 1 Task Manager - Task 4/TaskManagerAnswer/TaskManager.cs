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

        public void ListTasks()
        {
            if (tasks.Count == 0)
            {
                Console.WriteLine("No tasks.");
                return;
            }

            Console.WriteLine("Task List:");
            foreach (var task in tasks)
            {
                string status = task.Complete ? "Complete" : "Incomplete";
                Console.WriteLine($"ID: {task.Id} - Description: {task.Description} - Due Date: {task.DueDate} - Status: {status}");
            }
        }

        public void MarkTaskComplete(int taskId)
        {
            Task taskToComplete = tasks.Find(t => t.Id == taskId);
            if (taskToComplete == null)
            {
                Console.WriteLine("Task not found.");
                return;
            }
                
            taskToComplete.Complete = true;
            Console.WriteLine($"Task {taskId} marked as complete.");
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