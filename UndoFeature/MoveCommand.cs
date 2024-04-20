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
        private int _oldDx, _oldDy;
        private int _newDx, _newDy;

        public MoveCommand(Figure figure, int dx, int dy)
        {
            _figure = figure;
            _oldDx = dx;
            _oldDy = dy;
            _newDx = _figure.X;
            _newDy = _figure.Y;
        }

        public void Execute()
        {
            _figure.X = _newDx;
            _figure.Y = _newDy;
        }

        public void Undo()
        {
            _figure.X = _oldDx;
            _figure.Y = _oldDy;
        }
    }
}
