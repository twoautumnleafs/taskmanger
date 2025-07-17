using System;
using System.Collections.Generic;
using System.Linq;

namespace TaskTracker.Models
{
    public class User
    {
        public string Name { get; set; }
        public List<TaskBase> Tasks { get; private set; } = new();

        public User(string name)
        {
            Name = name;
        }

        public void AddTask(TaskBase task)
        {
            task.AssignedUser = this;
            Tasks.Add(task);
        }

        public void RemoveTask(Guid taskId)
        {
            Tasks.RemoveAll(t => t.Id == taskId);
        }

        public TaskBase FindTaskByTitle(string title)
        {
            return Tasks.FirstOrDefault(t => t.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
        }
    }
}