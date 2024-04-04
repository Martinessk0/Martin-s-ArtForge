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
    public partial class SettingsForm : Form
    {
        public Color CurrColor { get; private set; }
        public SettingsForm()
        {
            InitializeComponent();
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
