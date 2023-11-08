using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class TodoList
    {
        // Поле tasks представляет список задач
        public readonly List<Task> tasks = new List<Task>();

        // Метод для добавления задачи в список
        public void AddTask(Task task)
        {
            tasks.Add(task);
        }

        // Метод для удаления задачи из списка
        public void RemoveTask(Task task)
        {
            tasks.Remove(task);
        }

        // Метод для получения всех задач с наивысшим приоритетом
        public IEnumerable<Task> GetMostImportantTasks()
        {
            // Находим наивысший приоритет среди незавершенных задач
            var highestPriority = tasks.Where(t => !t.IsCompleted).Max(t => t.Priority);
            // Возвращаем все незавершенные задачи с наивысшим приоритетом
            return tasks.Where(t => !t.IsCompleted && t.Priority == highestPriority).ToList();
        }

        // Метод для получения всех задач, отсортированных по ближайшему дедлайну
        public IEnumerable<Task> GetNearestDeadlineTasks()
        {
            // Возвращаем все незавершенные задачи, отсортированные по дедлайну
            return tasks.Where(t => !t.IsCompleted).OrderBy(t => t.Deadline).ToList();
        }

        // Метод для получения всех задач в списке
        public IEnumerable<Task> AllTasks()
        {
            return tasks;
        }
    }
}
