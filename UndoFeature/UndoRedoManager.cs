namespace FinalProject.UndoFeature
{
    public class UndoRedoManager
    {
        private readonly List<ICommand> _commands = new List<ICommand>();

        private int _currentIndex = -1;

        public void ExecuteCommand(ICommand command)
        {
            // If there are commands after the current one, remove them
            if (_currentIndex < _commands.Count - 1)
            {
                _commands.RemoveRange(_currentIndex + 1, _commands.Count - _currentIndex - 1);
            }

            // Execute the command
            command.Execute();
            _commands.Add(command);
            _currentIndex = _commands.Count - 1;
        }

        public void Undo()
        {
            if (_currentIndex >= 0)
            {
                _commands[_currentIndex].Undo();
                _currentIndex--;
            }
        }

        public void Redo()
        {
            if (_currentIndex < _commands.Count - 1)
            {
                _currentIndex++;
                _commands[_currentIndex].Execute();
            }
        }

    }
}
