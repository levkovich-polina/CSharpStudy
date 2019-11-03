using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var application = new Application();

                Console.WriteLine("Что вы выбераете:");
                Console.WriteLine("1 - камень");
                Console.WriteLine("2 - ножницы");
                Console.WriteLine("3 - бумага");

                var keyInfo = Console.ReadKey(true);
                var key = keyInfo.Key;
                if (key == ConsoleKey.NumPad1)
                {
                    Console.WriteLine("Вы выбрали камень");
                    application.Choose(Figure.Rock);
                }
                else if (key == ConsoleKey.NumPad2)
                {
                    Console.WriteLine("Вы выбрали ножницы");
                    application.Choose(Figure.Scissors);
                }
                else if (key == ConsoleKey.NumPad3)
                {
                    Console.WriteLine("Вы выбрали бумагу");
                    application.Choose(Figure.Paper);
                }

                var rivalFigure = application.GetRivalFigure();
                if (rivalFigure == Figure.Rock)
                {
                    Console.WriteLine($"Соперник выбрал камень");
                }
                else if (rivalFigure == Figure.Scissors)
                {
                    Console.WriteLine($"Соперник выбрал ножницы");
                }
                else if (rivalFigure == Figure.Paper)
                {
                    Console.WriteLine($"Соперник выбрал бумагу");
                }

                var outcome = application.GetOutcome();
                if (outcome == Outcome.Lose)
                {
                    Console.WriteLine($"Вы проиграли");
                }
                else if (outcome == Outcome.Draw)
                {
                    Console.WriteLine($"Ничья");
                }
                else if (outcome == Outcome.Win)
                {
                    Console.WriteLine($"Вы выиграли");
                }

                Console.WriteLine();
            }
        }
    }
}
