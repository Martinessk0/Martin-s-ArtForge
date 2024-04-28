using FinalProject.Modules;

namespace FinalProject
{
    public partial class CalculationForm : Form
    {
        private List<Figure> _figures = new List<Figure>();
        public CalculationForm(List<Figure> figures)
        {
            InitializeComponent();
            _figures = figures;
        }
    }
}
