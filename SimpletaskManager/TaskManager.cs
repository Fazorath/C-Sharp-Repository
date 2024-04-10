using System;
using System.Collections.Generic;

namespace SimpleTaskManager
{
    public class TaskManager
    {
        private List<CustomTask> tasks;

        public TaskManager()
        {
            tasks = new List<CustomTask>();
        }

        public void AddTask(CustomTask task)
        {
            tasks.Add(task);
        }

        public void ListTasks()
        {
            Console.WriteLine("All Tasks:");
            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"[{i}] {tasks[i]}");
                Console.WriteLine("-----------------------");
            }
        }

        public void MarkTaskAsCompleted(int index)
        {
            if (index >= 0 && index < tasks.Count)
            {
                tasks[index].IsCompleted = true;
                Console.WriteLine("Task marked as completed.");
            }
            else
            {
                Console.WriteLine("Invalid task index.");
            }
        }

        public void DeleteTask(int index)
        {
            if (index >= 0 && index < tasks.Count)
            {
                tasks.RemoveAt(index);
                Console.WriteLine("Task deleted.");
            }
            else
            {
                Console.WriteLine("Invalid task index.");
            }
        }
    }
}
