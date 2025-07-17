using System;

namespace TaskTracker.Models
{
    public class OneTimeTask : TaskBase
    {
        public DateTime DueDate { get; set; }

        public OneTimeTask(string title, string description, DateTime dueDate)
            : base(title, description)
        {
            DueDate = dueDate;
        }

        public override void Display()
        {
            Console.WriteLine($"[OneTime] {Title} — Due: {DueDate.ToShortDateString()}");
        }
    }
}