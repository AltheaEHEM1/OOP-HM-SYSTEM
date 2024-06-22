using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using OxyPlot.WindowsForms;
using System;
using System.Windows.Forms;

namespace HOTEL_MANAGEMENT_SYSTEM.UI
{
    public partial class Revenue_db : UserControl
    {
        public Revenue_db()
        {
            InitializeComponent();
        }

        private void Revenue_db_Load(object sender, EventArgs e)
        {
            PlotView PV = new PlotView();
            PV.Dock = DockStyle.Fill;
            this.Controls.Add(PV);

            // Define PlotModel and set background color
            PlotModel plotModel = new PlotModel
            {
                Title = "Revenue",
                Background = OxyColor.FromRgb(240, 240, 240) // Light gray color
            };

            // Define X Axis as CategoryAxis for classifications
            CategoryAxis categoryAxis = new CategoryAxis
            {
                Position = AxisPosition.Bottom,
                Title = "Classification"
            };
            categoryAxis.Labels.Add("25 to 34");
            categoryAxis.Labels.Add("45 to 54");
            categoryAxis.Labels.Add("64 or over");
            categoryAxis.Labels.Add("Male");
            categoryAxis.Labels.Add("Female");

            // Define Y Axis as LinearAxis for frequencies
            LinearAxis linearAxis = new LinearAxis
            {
                Position = AxisPosition.Left,
                Title = "Frequency"
            };

            // Define LineSeries for Age groups
            LineSeries ageSeries = new LineSeries { Title = "Age" };
            ageSeries.Points.Add(new DataPoint(0, 301)); // 25 to 34
            ageSeries.Points.Add(new DataPoint(1, 140)); // 45 to 54
            ageSeries.Points.Add(new DataPoint(2, 100)); // 64 or over

            // Define LineSeries for Sex groups
            LineSeries sexSeries = new LineSeries { Title = "Sex" };
            sexSeries.Points.Add(new DataPoint(3, 584)); // Male
            sexSeries.Points.Add(new DataPoint(4, 416)); // Female

            // Add Axes and Series to the PlotModel
            plotModel.Axes.Add(categoryAxis);
            plotModel.Axes.Add(linearAxis);
            plotModel.Series.Add(ageSeries);
            plotModel.Series.Add(sexSeries);

            // Set the PlotModel to the PlotView
            PV.Model = plotModel;
        }
    }
}
