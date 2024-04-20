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
        private List<Figure> _oldFigures = new List<Figure>();
        private List<Figure> _figures;
        public MoveCommand(Figure figure, List<Figure> figures)
        {
            _figure = figure;
            _figures = figures;
            _oldFigures.AddRange(_figures);

        }
        public void Execute()
        {
            _figures.Add(_figure);
        }

        public void Undo()
        {
            _figures.Clear();
            _figures.AddRange(_oldFigures);
        }
    }
}
