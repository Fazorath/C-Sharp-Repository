namespace SimpleTaskManager
{
    public class CustomTask
    {
        // Needed Properties
        public string Title
        {
            get;
            set;
        }
        public string Description
        {
            get;
            set;
        }
        public DateTime DueDate
        {
            get;
            set;
        }
        public bool IsCompleted
        {
            get;
            set;
        }
        public CustomTask(string title, string description, DateTime dueDate, bool isCompleted)
        {
            // Constructor that is called
            Title = title;
            Description = description;
            DueDate = dueDate;
            IsCompleted = isCompleted;
        }
        public override string ToString()
        {
            // Called when list all functiion is called
            return $"Title: {Title}\nDescription: {Description}\nDue Date: {DueDate}\nIs Completed: {IsCompleted}";
        }
    }
}