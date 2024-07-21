using System;

namespace TaskManagerAnswer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TaskManager taskManager = new TaskManager();

            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Task Manager Menu:");
                Console.WriteLine("1. Add Task");
                Console.WriteLine("2. List Tasks");
                Console.WriteLine("3. Mark Task as Complete");
                Console.WriteLine("4. Delete Task");
                Console.WriteLine("5. Exit");

                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter task description: ");
                        string description = Console.ReadLine();
                        Console.Write("Enter due date (YYYY-MM-DD, optional): ");
                        string dueDateString = Console.ReadLine();
                        DateTime? dueDate = !string.IsNullOrWhiteSpace(dueDateString) ? DateTime.Parse(dueDateString) : null;

                        taskManager.AddTask(description, dueDate);

                        Console.WriteLine();
                        break;
                    case 2:
                        taskManager.ListTasks();

                        Console.WriteLine();
                        break;
                    case 3:
                        Console.Write("Enter task ID to mark as complete: ");
                        int taskId = int.Parse(Console.ReadLine());
                        taskManager.MarkTaskComplete(taskId);

                        Console.WriteLine();
                        break;
                    case 4:
                        Console.Write("Enter task ID to delete: ");
                        int taskIdToDelete = int.Parse(Console.ReadLine());
                        taskManager.DeleteTask(taskIdToDelete);

                        Console.WriteLine();
                        break;
                    case 5:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number from 1 to 5.");

                        Console.WriteLine();
                        break;
                }
            }
        }
    }
}