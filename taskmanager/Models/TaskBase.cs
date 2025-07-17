using System;

namespace TaskTracker.Models
{
    public abstract class TaskBase
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
        public string Title { get; set; }
        public string Description { get; set; }
        public Category Category { get; set; }
        public User AssignedUser { get; set; }

        protected TaskBase(string title, string description)
        {
            Title = title;
            Description = description;
        }

        public abstract void Display();
    }
}