using FinalProject.Modules;
using System.Reflection;

namespace FinalProject.UndoFeature
{
    public class EditingCommand : ICommand
    {
        private Figure _figure;
        private Figure _oldFigure;
        private Figure _newFigure;

        public EditingCommand(Figure figure,Figure oldFigure)
        {
            _figure = figure;
            _oldFigure = oldFigure; 
            _newFigure = figure.Clone();
            if (figure.IsFill == true)
            {
                _newFigure.IsFill = true;
            }
        }
        public void Execute()
        {
            PropertyInfo[] properties = _figure.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo property in properties)
            {
                if (property.CanWrite)
                {
                    object value = property.GetValue(_newFigure);
                    property.SetValue(_figure, value);
                }
            }
        }

        public void Undo()
        {
            PropertyInfo[] properties = _figure.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo property in properties)
            {
                if (property.CanWrite)
                {
                    object value = property.GetValue(_oldFigure);
                    property.SetValue(_figure, value);
                }
            }
        }
    }
}
