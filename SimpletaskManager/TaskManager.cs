using System;
using static System.Console;
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
            WriteLine("All Tasks:");
            ForegroundColor = ConsoleColor.Green;
            for (int i = 0; i < tasks.Count; i++)
            {
                WriteLine($"\n[{i}] {tasks[i]}");
                WriteLine("-----------------------");
            }
            ForegroundColor = ConsoleColor.Red;
            Write("\nPress Enter to move on!");
            ReadKey();
            Clear();
        }

        public void MarkTaskAsCompleted(int index)
        {
            if (index >= 0 && index < tasks.Count)
            {
                tasks[index].IsCompleted = true;
                ForegroundColor = ConsoleColor.Green;
                WriteLine("\nTask marked as completed.");
            }
            else
            {
                Clear();
                WriteLine("\nInvalid task index.");
            }
            Write("Press Enter to move on!");
            ReadKey();
            Clear();

        }

        public void DeleteTask(int index)
        {
            if (index >= 0 && index < tasks.Count)
            {
                tasks.RemoveAt(index);
                WriteLine("\nTask deleted.");
            }
            else
            {
                Clear();
                WriteLine("\nInvalid task index.");
            }
            Write("Press Enter to move on!");
            ReadKey();
            Clear();

        }
    }
}
