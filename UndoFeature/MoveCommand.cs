using FinalProject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.UndoFeature
{
    public class MoveCommand : ICommand
    {
        private Figure _figure;
        private int _oldX, _oldY;
        private int _newX, _newY;

        public MoveCommand(Figure figure, int x, int y)
        {
            _figure = figure;
            _oldX = x;
            _oldY = y;
            _newX = _figure.X;
            _newY = _figure.Y;
        }

        public void Execute()
        {
            _figure.X = _newX;
            _figure.Y = _newY;
        }

        public void Undo()
        {
            _figure.X = _oldX;
            _figure.Y = _oldY;
        }
    }
}
