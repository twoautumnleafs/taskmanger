using System;
using System.Collections.Generic;
using System.Linq;
using TaskTracker.Models;

namespace TaskTracker.Services
{
    public class TaskManager
    {
        private List<User> users = new();
        private List<Category> categories = new();

        public void AddUser(string name)
        {
            if (GetUser(name) == null)
                users.Add(new User(name));
        }

        public User GetUser(string name) =>
            users.FirstOrDefault(u => u.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

        public void AddCategory(string name)
        {
            if (GetCategory(name) == null)
                categories.Add(new Category(name));
        }

        public Category GetCategory(string name) =>
            categories.FirstOrDefault(c => c.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

        public void ShowAllTasks()
        {
            foreach (var user in users)
            {
                Console.WriteLine($"\nUser: {user.Name}");
                foreach (var task in user.Tasks)
                    task.Display();
            }
        }
    }
}