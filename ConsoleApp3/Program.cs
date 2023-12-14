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

            // Создание экземпляра TodoList для управления задачами
            var todoList = new TodoList();
            do
            {
                // Вывод меню для пользователя
                Console.WriteLine("1) Добавить задачу");
                Console.WriteLine("2) Вывести все задачи");

                // Ждем ввода пользователя
                var key = Console.ReadKey();//считывает следующий символ из стандартного входного потока
                                            // и возвращает объект типа ConsoleKeyInfo, представляющий информацию о нажатой клавише.
                Console.WriteLine();

                // Обработка выбора пользователя
                switch (key.KeyChar) //получение значения символа
                {
                    
                    case '1':
                        { 
                            var task = ReadTask();
                            todoList.AddTask(task);
                            break;
                        }
                    case '2':
                        {
                            // Вывод всех задач
                            foreach (var todo in todoList.AllTasks()) //todo - переменная, которая будет содержать каждую задачу поочередно из коллекции, возвращенной методом AllTasks().
                            {
                                PrintTask(todo); //выводит информацию о задаче в консоль. todo
                            }
                            break;
                        }
                }
            }
            while (Console.ReadKey().KeyChar != 'q'); //это условие цикла. Цикл будет выполняться, пока символ, введенный пользователем, не равен символу 'q'
        }
        //метод печати задач
        static void PrintTask(Task task)
        {
            Console.WriteLine($"{task.Title}-{task.Deadline}"); //task.Title: Получает название задачи. task.Deadline: Получает дедлайн задачи.
        }

        //чтение задачи
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
