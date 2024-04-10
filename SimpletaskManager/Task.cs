using System;

namespace SimpleTaskManager
{
    public class CustomTask
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsCompleted { get; set; }

        public CustomTask(string title, string description, DateTime dueDate, bool isCompleted)
        {
            Title = title;
            Description = description;
            DueDate = dueDate;
            IsCompleted = isCompleted;
        }

        public override string ToString()
        {
            return $"Title: {Title}\nDescription: {Description}\nDue Date: {DueDate}\nIs Completed: {IsCompleted}";
        }
    }
}
