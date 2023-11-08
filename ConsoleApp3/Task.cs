using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Класс Task представляет собой шаблон для создания объектов, представляющих задачи в  приложении.
//Title свойство класса, представляющее название задачи. Свойства get и set автоматически создают методы для чтения (get) и записи(set) значения этого свойства.
//Priority аналогично,  свойство представляет приоритет задачи.
//DateTime представляет дедлайн задачи в виде объекта DateTime.

public bool IsCompleted { get; set; }: Это свойство представляет флаг завершения задачи. Если значение IsCompleted равно true, то задача считается завершенной.
namespace ConsoleApp3
{// Определение публичного класса Task
    public class Task
    {
        public string Title { get; set; }
        public int Priority { get; set; }
        public DateTime Deadline { get; set; }
        public bool IsCompleted { get; set; }
    }
}