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
            // Initializes a new instance of the CustomTask class.
            // Parameters:
            // title: The title of the task.
            // description: The description of the task.
            // dueDate: The due date of the task.
            // isCompleted: A value indicating whether the task is completed.
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