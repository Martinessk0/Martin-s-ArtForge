namespace FinalProject.UndoFeature
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}
