﻿using FinalProject.Modules;

namespace FinalProject.UndoFeature
{
    public class FillCommand : ICommand
    {
        private Figure _figure;
        private Color _color;
        private Color _oldColor;

        public FillCommand(Figure figure,Color color)
        {
            _figure = figure;
            _color = color;
            _oldColor = figure.FillColor;
        }

        public void Execute()
        {
            _figure.FillColor = _color;
            _figure.IsFill = true;
        }

        public void Undo()
        {
            _figure.FillColor = _oldColor;
            _figure.IsFill = false;
        }
    }
}
