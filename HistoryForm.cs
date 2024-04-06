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
    public partial class HistoryForm : Form
    {
        public HistoryForm(ListBox _historyListBox)
        {
            InitializeComponent();
            this.historyListBox.Text = _historyListBox.Text;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void HistoryForm_Load(object sender, EventArgs e)
        {

        }
    }
}
