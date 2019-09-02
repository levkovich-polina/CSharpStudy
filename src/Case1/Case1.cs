using System;

namespace Case1
{
    class Case1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер дня недели");
            var number = int.Parse(Console.ReadLine());

            string dayOfWeek = null;
            switch (number)
            {
                case 1:
                    dayOfWeek = "Понедельник";
                    break;
                case 2:
                    dayOfWeek = "Вторник";
                    break;
                case 3:
                    dayOfWeek = "Среда";
                    break;
                case 4:
                    dayOfWeek = "Четверг";
                    break;
                case 5:
                    dayOfWeek = "Пятница";
                    break;
                case 6:
                    dayOfWeek = "Суббота";
                    break;
                case 7:
                    dayOfWeek = "Воскресенье";
                    break;
                default:
                    dayOfWeek = "Дня недели с данным номером не существует";
                    break;
            }

            Console.WriteLine(dayOfWeek);
            Console.ReadLine();
        }
    }
}
