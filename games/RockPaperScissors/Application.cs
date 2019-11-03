using System;

namespace RockPaperScissors
{
    public class Application
    {
        private readonly Random _random = new Random();
        private Figure _userFigure;
        private readonly Figure _rivalFigure;

        public Application()
        {
            var number = _random.Next(3);
            if (number == 0)
            {
                _rivalFigure = Figure.Rock;
            }
            else if (number == 1)
            {
                _rivalFigure = Figure.Scissors;
            }
            else
            {
                _rivalFigure = Figure.Paper;
            }
        }

        public void Choose(Figure figure)
        {
            _userFigure = figure;
        }

        public Figure GetRivalFigure()
        {
            return _rivalFigure;
        }

        public Outcome GetOutcome()
        {
            if (_userFigure == _rivalFigure)
            {
                return Outcome.Draw;
            }

            if (_userFigure == Figure.Rock && _rivalFigure == Figure.Paper
                || _userFigure == Figure.Paper && _rivalFigure == Figure.Scissors
                || _userFigure == Figure.Scissors && _rivalFigure == Figure.Rock)
            {
                return Outcome.Lose;
            }

            return Outcome.Win;
        }
    }
}
