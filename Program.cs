using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    class Program
    {
        /// <summary>
        /// Код для ДЗ №2
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            /* 
                описание переменых для сотрудников. По одной каждого типа для каждого сотрудника.
                TODO: описать отдельный класс Employer) 
            */
            string name1, name2, name3;
            int age1, age2, age3;
            int tall1, tall2, tall3;
            int rusPoint1, rusPoint2, rusPoint3;
            int hisPoint1, hisPoint2, hisPoint3;
            int mathPoint1, mathPoint2, mathPoint3;
            double avgPoint1, avgPoint2, avgPoint3;
            string s1 = "* * * * *  Ввод информации   * * * * *";
            string s2 = "* * * * *  Вывод информации   * * * * *";
            int startPosition1 = Console.WindowWidth / 2 - s1.Length / 2;
            int startPosition2 = Console.WindowWidth / 2 - s2.Length / 2;

            //Вывод по центру. Ввод инфы
            Console.SetCursorPosition(startPosition1, 0);
            Console.WriteLine(s1);

            //Запрашиваем данные 1 сотрудника
            Console.WriteLine("Первый сотрудник.");
            Console.WriteLine("Введите имя: ");
            name1 = Console.ReadLine();
            Console.WriteLine("Введите возраст: ");
            Int32.TryParse(Console.ReadLine(), out age1);
            Console.WriteLine("Введите рост: ");
            Int32.TryParse(Console.ReadLine(), out tall1);
            Console.WriteLine("Введите балл по русскому языку: ");
            Int32.TryParse(Console.ReadLine(), out rusPoint1);
            Console.WriteLine("Введите балл по истории: ");
            Int32.TryParse(Console.ReadLine(), out hisPoint1);
            Console.WriteLine("Введите балл по математике: ");
            Int32.TryParse(Console.ReadLine(), out mathPoint1);
            avgPoint1 = ((double)rusPoint1 + (double)hisPoint1 + (double)hisPoint1) / 3;

            Console.WriteLine();

            //Запрашиваем данные 2 сотрудника
            Console.WriteLine("Второй сотрудник.");
            Console.WriteLine("Введите имя: ");
            name2 = Console.ReadLine();
            Console.WriteLine("Введите возраст: ");
            Int32.TryParse(Console.ReadLine(), out age2);
            Console.WriteLine("Введите рост: ");
            Int32.TryParse(Console.ReadLine(), out tall2);
            Console.WriteLine("Введите балл по русскому языку: ");
            Int32.TryParse(Console.ReadLine(), out rusPoint2);
            Console.WriteLine("Введите балл по истории: ");
            Int32.TryParse(Console.ReadLine(), out hisPoint2);
            Console.WriteLine("Введите балл по математике: ");
            Int32.TryParse(Console.ReadLine(), out mathPoint2);
            avgPoint2 = ((double)rusPoint2 + (double)hisPoint2 + (double)hisPoint2) / 3;
            Console.WriteLine();

            //Запрашиваем данные 3 сотрудника
            Console.WriteLine("Третий сотрудник.");
            Console.WriteLine("Введите имя: ");
            name3 = Console.ReadLine();
            Console.WriteLine("Введите возраст: ");
            Int32.TryParse(Console.ReadLine(), out age3);
            Console.WriteLine("Введите рост: ");
            Int32.TryParse(Console.ReadLine(), out tall3);
            Console.WriteLine("Введите балл по русскому языку: ");
            Int32.TryParse(Console.ReadLine(), out rusPoint3);
            Console.WriteLine("Введите балл по истории: ");
            Int32.TryParse(Console.ReadLine(), out hisPoint3);
            Console.WriteLine("Введите балл по математике: ");
            Int32.TryParse(Console.ReadLine(), out mathPoint3);
            avgPoint3 = ((double)rusPoint3 + (double)hisPoint3 + (double)hisPoint3) / 3;
            Console.WriteLine();


            //Вывод по центру. Вывод инфы
            Console.Clear();
            Console.SetCursorPosition(startPosition2, 0);
            Console.WriteLine(s2);

            // Вывод инфы о 1 сотруднике
            Console.WriteLine("Первый сотрудник.");
            Console.WriteLine("Имя: " + name1);
            Console.WriteLine("Возраст: " + age1);
            Console.WriteLine("Рост: " + tall1);
            Console.WriteLine("Баллы по русскому языку: " + rusPoint1);
            Console.WriteLine("Баллы по истории: " + hisPoint1);
            Console.WriteLine("Баллы по математике: " + mathPoint1);
            Console.WriteLine("Средний балл по предметам: " + avgPoint1.ToString("###.##"));
            Console.WriteLine();

            // Вывод инфы о 2 сотруднике
            Console.WriteLine("Второй сотрудник.");
            Console.WriteLine("Имя: {0} ", name2);
            Console.WriteLine("Возраст: {0}", age2);
            Console.WriteLine("Рост: {0}", tall2);
            Console.WriteLine("Баллы по русскому языку: {0}", rusPoint2);
            Console.WriteLine("Баллы по истории: {0}", hisPoint2);
            Console.WriteLine("Баллы по математике: {0}", mathPoint2);
            Console.WriteLine("Средний балл по предметам: {0}", avgPoint2.ToString("###.##"));
            Console.WriteLine();

            // Вывод инфы о 3 сотруднике
            Console.WriteLine("Третий сотрудник.");
            Console.WriteLine($"Имя: {name3}");
            Console.WriteLine($"Возраст: {age3}");
            Console.WriteLine($"Рост: {tall3}");
            Console.WriteLine($"Баллы по русскому языку: {rusPoint3}");
            Console.WriteLine($"Баллы по истории: {hisPoint3}");
            Console.WriteLine($"Баллы по математике: {mathPoint3}");
            Console.WriteLine($"Средний балл по предметам: {avgPoint3.ToString("###.##")}");
            Console.WriteLine();


            //Чтобы не закрылось
            Console.ReadLine();

        }
    }
}
