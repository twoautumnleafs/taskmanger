using System;

namespace TaskTracker.Models
{
    public class RecurringTask : TaskBase
    {
        public TimeSpan RepeatInterval { get; set; }

        public RecurringTask(string title, string description, TimeSpan interval)
            : base(title, description)
        {
            RepeatInterval = interval;
        }

        public override void Display()
        {
            Console.WriteLine($"[Recurring] {Title} — Every {RepeatInterval.TotalDays} days");
        }
    }
}