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

            Figure.WidthInCm = PixelsToCM(Figure.Width, _dpiX);
            Figure.HeightInCm = PixelsToCM(Figure.Height, _dpiY);
            Figure.CalculasArea();

            if (Figure.GetType().Name == "Line")
            {
                lblX.Visible = true;
                lblY.Visible = true;
                txtStartY.Visible = true;
                txtEndY.Visible = true;
                lblFillColor.Visible = false;
                lblFill.Visible = false;
                btnColorFill.Visible = false;
                lblWidth.Text = "Start:";
                lblHeight.Text = "End:";
                txtWidth.Text = Figure.Start.X.ToString();
                txtStartY.Text = Figure.Start.Y.ToString();
                txtHeight.Text = Figure.End.X.ToString();
                txtEndY.Text = Figure.End.Y.ToString();
            }
            else if (Figure.GetType().Name == "Square")
            {
                txtHeight.Enabled = false;
                txtHeight.Text = Figure.Width.ToString();
                txtWidth.Text = Figure.Width.ToString();
                txtArea.Text = $"{Figure.Area:0.00}";
                lblOutlineColor.BackColor = _outlineColor;
                lblFillColor.BackColor = _fillColor;
            }
            else
            {
                txtHeight.Text = Figure.Height.ToString();
                txtWidth.Text = Figure.Width.ToString();
                txtArea.Text = $"{Figure.Area:0.00}";
                lblOutlineColor.BackColor = _outlineColor;
                lblFillColor.BackColor = _fillColor;
            }
        }


        private double PixelsToCM(int pixels, double dpi)
        {
            return pixels / dpi * _cmToInch;
        }

        private void btnResize_Click(object sender, EventArgs e)
        {
           
            if (Figure.GetType().Name == "Line")
            {
                int startX, startY, endX, endY;
                startX = int.Parse(txtWidth.Text);
                startY = int.Parse(txtStartY.Text);
                endX = int.Parse(txtHeight.Text);
                endY = int.Parse(txtEndY.Text);
                Point start = new Point(startX, startY);
                Point end = new Point(endX, endY);
                Figure.Start = start;
                Figure.End = end;
                txtWidth.Text = Figure.Start.X.ToString();
                txtStartY.Text = Figure.Start.Y.ToString();
                txtHeight.Text = Figure.End.X.ToString();
                txtEndY.Text = Figure.End.Y.ToString();
            }
            else if (Figure.GetType().Name == "Square")
            {
               
                Figure.Width = int.Parse(txtWidth.Text);
                Figure.Height = int.Parse(txtWidth.Text);
                txtHeight.Text = Figure.Width.ToString();
            }
            else
            {
                Figure.Width = int.Parse(txtWidth.Text);
                Figure.Height = int.Parse(txtHeight.Text);
                txtHeight.Text = Figure.Height.ToString();
                txtWidth.Text = Figure.Width.ToString();
            }

            lblOutlineColor.BackColor = _outlineColor;
            lblFillColor.BackColor = _fillColor;
            Figure.OutlineColor = _outlineColor;
            Figure.FillColor = _fillColor;
            Figure.IsFill = _fillColor != Color.Transparent ? true : false;
            Figure.WidthInCm = PixelsToCM(Figure.Width, _dpiX);
            Figure.HeightInCm = PixelsToCM(Figure.Height, _dpiY);
            Figure.CalculasArea();
            txtArea.Text = $"{Figure.Area:0.00}";
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
