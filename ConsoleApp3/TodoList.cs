using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class TodoList
    {
        public readonly List<Task> tasks = new List<Task>();

        public void AddTask(Task task)
        {
            tasks.Add(task);
        }

        public void RemoveTask(Task task)
        {
            tasks.Remove(task);
        }

        public IEnumerable<Task> GetMostImportantTasks()
        {
            var highestPriority = tasks.Where(t => !t.IsCompleted).Max(t => t.Priority);
            return tasks.Where(t => !t.IsCompleted && t.Priority == highestPriority).ToList();
        }

        public IEnumerable<Task> GetNearestDeadlineTasks()
        {
            return tasks.Where(t => !t.IsCompleted).OrderBy(t => t.Deadline).ToList();
        }

        public IEnumerable<Task> AllTasks()
        {
            return tasks;
        }
    }
}
