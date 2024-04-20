using FinalProject.Modules;

namespace FinalProject.UndoFeature
{
    public class EraseCommand : ICommand
    {
        private Figure _figure;
        private List<Figure> _figures;

        public EraseCommand(List<Figure> figures,Figure figure)
        {
            _figures = figures;
            _figure = figure;
        }

        public void Execute()
        {
            _figures.Remove(_figure);
        }

        public void Undo()
        {
            _figures.Add(_figure);
        }
    }
}
