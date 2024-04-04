using FinalProject.Modules;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class ShapesForm : Form
    {
        public static Color CurrColor { get; private set; }

        public ShapesForm()
        {
            InitializeComponent();
            switch (MainForm._currentDrawingMode)
            {
                case DrawingMode.Rectangle:
                    MainForm.SelectButton(btnRectangular);
                    break;
                case DrawingMode.Square:
                    MainForm.SelectButton(btnSquare);
                    break;
                case DrawingMode.Line:
                    MainForm.SelectButton(btnLine);
                    break;
                case DrawingMode.Circle:
                    MainForm.SelectButton(btnCircle);
                    break;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRectangular_Click(object sender, EventArgs e)
        {
            MainForm._currentDrawingMode = DrawingMode.Rectangle;
            MainForm._isMovable = false;
            MainForm._isReadyForFilling = false;
            MainForm.SelectButton(btnRectangular);
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            MainForm._currentDrawingMode = DrawingMode.Square;
            MainForm._isMovable = false;
            MainForm._isReadyForFilling = false;
            MainForm.SelectButton(btnSquare);
        }

        private void btnLine_Click(object sender, EventArgs e)
        {
            MainForm._currentDrawingMode = DrawingMode.Line;
            MainForm._isMovable = false;
            MainForm._isReadyForFilling = false;
            MainForm.SelectButton(btnLine);
        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            MainForm._currentDrawingMode = DrawingMode.Circle;
            MainForm._isMovable = false;
            MainForm._isReadyForFilling = false;
            MainForm.SelectButton(btnCircle);
        }

        private void pickColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            DialogResult result = colorDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                CurrColor = colorDialog.Color;
            }
        }
    }
}
