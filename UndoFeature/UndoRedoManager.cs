namespace FinalProject.UndoFeature
{
    public class UndoRedoManager
    {
        private readonly List<ICommand> _commands = new List<ICommand>();
        private readonly ListBox _historyTextBox = new ListBox();

        public ListBox HistoryTextBox
        {
            get
            {
                return _historyTextBox;
            }

            private set
            {
                value = _historyTextBox;
            }
        }

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
                var historyCommand = _commands[_currentIndex].GetType().Name;
                HistoryTextBox.Text += "Undo";
                HistoryTextBox.Text += Environment.NewLine;
                HistoryTextBox.Text += historyCommand;
                HistoryTextBox.Text += Environment.NewLine;
                HistoryTextBox.Text += Environment.NewLine;
                _currentIndex--;
            }
        }

        public void Redo()
        {
            if (_currentIndex < _commands.Count - 1)
            {
                _currentIndex++;
                var historyCommand = _commands[_currentIndex].GetType().Name;
                HistoryTextBox.Text += "Redo";
                HistoryTextBox.Text += Environment.NewLine;
                HistoryTextBox.Text += historyCommand;
                HistoryTextBox.Text += Environment.NewLine;
                HistoryTextBox.Text += Environment.NewLine;
                _commands[_currentIndex].Execute();
            }
        }

    }
}
