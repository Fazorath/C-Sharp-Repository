using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTaskManager
{
    internal class CustomTask
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public TimeSpan Duration { get; set; }
        public bool IsCompleted { get; set; }

        public CustomTask(string title, string description, TimeSpan duration, bool isCompleted)
        {
            Title = title;
            Description = description;
            Duration = duration;
            IsCompleted = isCompleted;
        }


    }
}
