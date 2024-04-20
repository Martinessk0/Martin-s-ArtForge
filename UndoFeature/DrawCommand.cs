using FinalProject.Modules;

namespace FinalProject.UndoFeature
{
    public class DrawCommand : ICommand
    {
        private Figure _figure;
        private List<Figure> _figures;
        public DrawCommand(List<Figure> figures,Figure figure)
        {
            _figure = figure;
            _figures = figures;
        }
        public void Execute()
        {
            _figures.Add(_figure);
        }

        public void Undo()
        {
            _figures.Remove(_figure);
        }
    }
}
