using FinalProject.Modules;

namespace FinalProject
{
    public partial class CalculationForm : Form
    {
        private List<Figure> _figures = new List<Figure>();
        private Color _targetColor = Color.Black;
        public CalculationForm(List<Figure> figures)
        {
            InitializeComponent();
            _figures = figures;
        }

        private void CalculationForm_Load(object sender, EventArgs e)
        {
            lblColor.BackColor = _targetColor;

            var countByFillColor = _figures.Count(figure => figure.FillColor == _targetColor);
            lblCountSameFillColor.Text = countByFillColor.ToString();

            var countByOutlineColor = _figures.Count(figure => figure.OutlineColor == _targetColor);
            lblCountSameOutlineColor.Text = countByOutlineColor.ToString();

            var countAllFigures = _figures
                .Count();
            lblCountAllFigures.Text = countAllFigures.ToString();
        }

        private void btnChooseColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            DialogResult result = colorDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                _targetColor = colorDialog.Color;
                lblColor.BackColor = _targetColor;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            lblColor.BackColor = _targetColor;

            var countByFillColor = _figures.Count(figure => figure.FillColor == _targetColor);
            lblCountSameFillColor.Text = countByFillColor.ToString();

            var countByOutlineColor = _figures.Count(figure => figure.OutlineColor == _targetColor);
            lblCountSameOutlineColor.Text = countByOutlineColor.ToString();

            var countAllFigures = _figures
                .Count();
            lblCountAllFigures.Text = countAllFigures.ToString();

        }
    }
}
