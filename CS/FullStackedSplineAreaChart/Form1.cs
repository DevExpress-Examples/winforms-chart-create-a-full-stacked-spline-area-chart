using System;
using System.Windows.Forms;
using DevExpress.XtraCharts;
// ...

namespace FullStackedSplineAreaChart {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // Create an empty chart.
            ChartControl fullStackedSplineAreaChart = new ChartControl();

            // Create two series of the FullStackedSplineArea view type.
            Series series1 = new Series("Series 1", ViewType.FullStackedSplineArea);
            Series series2 = new Series("Series 2", ViewType.FullStackedSplineArea);

            // Populate both series with points.
            series1.Points.Add(new SeriesPoint("A", 80));
            series1.Points.Add(new SeriesPoint("B", 20));
            series1.Points.Add(new SeriesPoint("C", 50));
            series1.Points.Add(new SeriesPoint("D", 30));
            series2.Points.Add(new SeriesPoint("A", 40));
            series2.Points.Add(new SeriesPoint("B", 60));
            series2.Points.Add(new SeriesPoint("C", 20));
            series2.Points.Add(new SeriesPoint("D", 80));

            // Add the series to the chart.
            fullStackedSplineAreaChart.Series.AddRange(new Series[] {
                series1, series2});

            // Adjust the view-type-specific options of the series.
            ((FullStackedSplineAreaSeriesView)series1.View).LineTensionPercent = 80;
            ((FullStackedSplineAreaSeriesView)series2.View).Transparency = 80;

            // Access the diagram's options.
            ((XYDiagram)fullStackedSplineAreaChart.Diagram).Rotated = true;

            // Add a title to the chart and hide the legend.
            ChartTitle chartTitle1 = new ChartTitle();
            chartTitle1.Text = "Full Stacked Spline Area Chart";
            fullStackedSplineAreaChart.Titles.Add(chartTitle1);
            fullStackedSplineAreaChart.Legend.Visible = false;

            // Add the chart to the form.
            fullStackedSplineAreaChart.Dock = DockStyle.Fill;
            this.Controls.Add(fullStackedSplineAreaChart);
        }

    }
}