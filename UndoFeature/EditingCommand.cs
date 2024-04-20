using FinalProject.Modules;

namespace FinalProject.UndoFeature
{
    public class EditingCommand : ICommand
    {
        private Figure _figure;
        private List<Figure> _figures;
        private Figure _oldFigure;

        public EditingCommand(List<Figure> figures,Figure figure,Figure oldFigure)
        {
            _figure = figure;
            _figures = figures;
            _oldFigure = oldFigure;

        }
        public void Execute()
        {
            _figures.Remove(_oldFigure);
            _figures.Add(_figure);
        }

        public void Undo()
        {
            _figures.Remove(_figure);
            _figures.Add(_oldFigure);   
        }
    }
}
