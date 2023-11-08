using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var todoList = new TodoList();
            do
            {
                Console.WriteLine("1) Добавить задачу");
                Console.WriteLine("2) Вывести все задачи");
                var key = Console.ReadKey();
                Console.WriteLine();
                switch (key.KeyChar)
                {
                    case '1':
                        {
                            var task = ReadTask();
                            todoList.AddTask(task);
                            break;
                        }
                    case '2':
                        {
                            foreach (var todo in todoList.AllTasks())
                            {
                                PrintTask(todo);
                            }
                            break;
                        }
                }
            }
            while (Console.ReadKey().KeyChar != 'q');
        }

        static void PrintTask(Task task)
        {
            Console.WriteLine($"{task.Title}-{task.Deadline}");
        }

        static Task ReadTask()
        {
            Console.Write("Введите название задачи: ");
            string taskName = Console.ReadLine();
            Console.Write("Введите приоритет: ");
            int priority = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите дедлайн (гггг-мм-дд): ");
            DateTime deadline = DateTime.Parse(Console.ReadLine());
            return new Task
            {
                Deadline = deadline,
                IsCompleted = false,
                Priority = priority,
                Title = taskName
            };
        }
    }
}
