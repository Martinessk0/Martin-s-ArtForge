using FinalProject.Modules;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class CurrFigureInfo : Form
    {
        private double _dpiX, _dpiY;
        private const double _cmToInch = 2.54;
        private Color _outlineColor;
        private Color _fillColor;

        public Figure Figure { get; private set; }

        public CurrFigureInfo()
        {
            InitializeComponent();
        }
        public CurrFigureInfo(Figure figure, double dpiX, double dpiY)
        {
            InitializeComponent();
            Figure = figure;
            _outlineColor = Figure.OutlineColor;
            _fillColor = Figure.FillColor;
            _dpiX = dpiX;
            _dpiY = dpiY;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void CurrFigureInfo_Load(object sender, EventArgs e)
        {
            lblName.Text = Figure.GetType().Name;
            switch (Figure.GetType().Name)
            {
                case "Square":
                    txtHeight.Enabled = false;
                    txtHeight.Text = Figure.Width.ToString();
                    break;
                case "Line":
                    lblFillColor.Visible = false;
                    lblFill.Visible = false;
                    btnColorFill.Visible = false;
                    break;
                default:
                    break;
            }
            txtHeight.Text = Figure.Height.ToString();
            txtWidth.Text = Figure.Width.ToString();
            Figure.WidthInCm = PixelsToCM(Figure.Width, _dpiX);
            Figure.HeightInCm = PixelsToCM(Figure.Height, _dpiY);
            Figure.CalculasArea();
            txtArea.Text = $"{Figure.Area:0.00}";
            lblOutlineColor.BackColor = _outlineColor;
            lblFillColor.BackColor = _fillColor;
        }

        private double PixelsToCM(int pixels, double dpi)
        {
            return pixels / dpi * _cmToInch;
        }

        private void btnResize_Click(object sender, EventArgs e)
        {
            switch (Figure.GetType().Name)
            {
                case "Square":
                    txtHeight.Enabled = false;
                    txtHeight.Text = Figure.Width.ToString();
                    break;
                case "Line":
                    lblFillColor.Visible = false;
                    lblFill.Visible = false;
                    btnColorFill.Visible = false;
                    break;
                default:
                    break;
            }

            Figure.Width = int.Parse(txtWidth.Text);
            Figure.Height = int.Parse(txtHeight.Text);
            Figure.OutlineColor = _outlineColor;
            Figure.FillColor = _fillColor;
            Figure.IsFill = true;

            Figure.WidthInCm = PixelsToCM(Figure.Width, _dpiX);
            Figure.HeightInCm = PixelsToCM(Figure.Height, _dpiY);

            Figure.CalculasArea();

            txtHeight.Text = Figure.Height.ToString();
            txtWidth.Text = Figure.Width.ToString();
            txtArea.Text = $"{Figure.Area:0.00}";
            lblOutlineColor.BackColor = _outlineColor;
            lblFillColor.BackColor = _fillColor;

          
        }

        private void btnColorOutline_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            DialogResult result = dlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                _outlineColor = dlg.Color;
                lblOutlineColor.BackColor = _outlineColor;
            }
        }

        private void btnColorFill_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            DialogResult result = dlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                _fillColor = dlg.Color;
                lblFillColor.BackColor = _fillColor;
            }
        }
    }
}
