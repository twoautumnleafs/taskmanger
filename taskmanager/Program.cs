using TaskTracker.Models;
using TaskTracker.Services;

namespace TaskTracker
{
    class Program
    {
        static void Main()
        {
            TaskManager manager = new TaskManager();

            manager.AddUser("Name");
            manager.AddCategory("Work");

            var user = manager.GetUser("Name");
            var category = manager.GetCategory("Work");

            var task1 = new OneTimeTask("Finish report", "Monthly report", DateTime.Now.AddDays(2))
            {
                Category = category
            };
            user.AddTask(task1);

            var task2 = new RecurringTask("Backup data", "Backup server", TimeSpan.FromDays(1))
            {
                Category = category
            };
            user.AddTask(task2);

            manager.ShowAllTasks();
        }
    }
}