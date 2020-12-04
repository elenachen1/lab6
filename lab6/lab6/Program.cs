using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            Work w1 = new Work("Печать пылеотвода", 1000);
            Work w2 = new Work("Печать турбины", 500);
            Work w3 = new Work("Печать корабля", 5000);

            Work w11 = new Work("Создание прототапа робота", 10000);
            Work w12 = new Work("Создание печатной платы(драйвер для моторов)", 5000);
            Work w13 = new Work("Сборка 3д принтера", 8000);

            Console.WriteLine("Введите цену за печать ляушки из пластика ABS");
            try
            {
                Work w4 = new Work("Печать лягушки", int.Parse(Console.ReadLine()));
            }

            catch (Exception x)
            {
                Console.WriteLine("Error");
                Console.WriteLine(x.Message);
            }
           

            List <Work> report = new List<Work>() { w1, w2, w3, w11, w12, w13};
            List<Work> report_2 = report.Where(w => w.price == 5000).ToList();
            List<Work> report_3 = report.OrderBy(w => w.name).ToList();
        }
    }
}
