Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraCharts
' ...

Namespace FullStackedSplineAreaChart
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            ' Create an empty chart.
            Dim fullStackedSplineAreaChart As New ChartControl()

            ' Create two series of the FullStackedSplineArea view type.
            Dim series1 As New Series("Series 1", ViewType.FullStackedSplineArea)
            Dim series2 As New Series("Series 2", ViewType.FullStackedSplineArea)

            ' Populate both series with points.
            series1.Points.Add(New SeriesPoint("A", 80))
            series1.Points.Add(New SeriesPoint("B", 20))
            series1.Points.Add(New SeriesPoint("C", 50))
            series1.Points.Add(New SeriesPoint("D", 30))
            series2.Points.Add(New SeriesPoint("A", 40))
            series2.Points.Add(New SeriesPoint("B", 60))
            series2.Points.Add(New SeriesPoint("C", 20))
            series2.Points.Add(New SeriesPoint("D", 80))

            ' Add the series to the chart.
            fullStackedSplineAreaChart.Series.AddRange(New Series() { series1, series2})

            ' Adjust the view-type-specific options of the series.
            CType(series1.View, FullStackedSplineAreaSeriesView).LineTensionPercent = 80
            CType(series2.View, FullStackedSplineAreaSeriesView).Transparency = 80

            ' Access the diagram's options.
            CType(fullStackedSplineAreaChart.Diagram, XYDiagram).Rotated = True

            ' Add a title to the chart and hide the legend.
            Dim chartTitle1 As New ChartTitle()
            chartTitle1.Text = "Full Stacked Spline Area Chart"
            fullStackedSplineAreaChart.Titles.Add(chartTitle1)
            fullStackedSplineAreaChart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False

            ' Add the chart to the form.
            fullStackedSplineAreaChart.Dock = DockStyle.Fill
            Me.Controls.Add(fullStackedSplineAreaChart)
        End Sub

    End Class
End Namespace