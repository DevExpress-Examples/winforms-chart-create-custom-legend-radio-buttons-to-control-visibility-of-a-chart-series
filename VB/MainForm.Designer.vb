Imports Microsoft.VisualBasic
Imports System
Namespace CustomCheckboxesInLegendViewAndBehavior
	Partial Public Class mainForm
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim xyDiagram1 As New DevExpress.XtraCharts.XYDiagram()
			Dim series1 As New DevExpress.XtraCharts.Series()
			Dim pointSeriesLabel1 As New DevExpress.XtraCharts.PointSeriesLabel()
			Dim pointSeriesView1 As New DevExpress.XtraCharts.PointSeriesView()
			Dim series2 As New DevExpress.XtraCharts.Series()
			Dim pointSeriesLabel2 As New DevExpress.XtraCharts.PointSeriesLabel()
			Dim pointSeriesView2 As New DevExpress.XtraCharts.PointSeriesView()
			Dim series3 As New DevExpress.XtraCharts.Series()
			Dim pointSeriesLabel3 As New DevExpress.XtraCharts.PointSeriesLabel()
			Dim pointSeriesView3 As New DevExpress.XtraCharts.PointSeriesView()
			Dim pointSeriesLabel4 As New DevExpress.XtraCharts.PointSeriesLabel()
			Dim pointSeriesView4 As New DevExpress.XtraCharts.PointSeriesView()
			Dim chartTitle1 As New DevExpress.XtraCharts.ChartTitle()
			Me.chartControlDistributions = New DevExpress.XtraCharts.ChartControl()
			CType(Me.chartControlDistributions, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(pointSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(pointSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(pointSeriesLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(pointSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(pointSeriesLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(pointSeriesView3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(pointSeriesLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(pointSeriesView4, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' chartControlDistributions
			' 
			xyDiagram1.AxisX.VisualRange.Auto = False
			xyDiagram1.AxisX.VisualRange.MaxValueSerializable = "100"
			xyDiagram1.AxisX.VisualRange.MinValueSerializable = "0"
			xyDiagram1.AxisX.WholeRange.MaxValueSerializable = "100"
			xyDiagram1.AxisX.WholeRange.MinValueSerializable = "0"
			xyDiagram1.AxisX.WholeRange.AutoSideMargins = False
			xyDiagram1.AxisX.VisualRange.AutoSideMargins = False
			xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
			xyDiagram1.AxisY.VisualRange.Auto = False
			xyDiagram1.AxisY.VisualRange.MaxValueSerializable = "100"
			xyDiagram1.AxisY.VisualRange.MinValueSerializable = "0"
			xyDiagram1.AxisY.WholeRange.MaxValueSerializable = "100"
			xyDiagram1.AxisY.WholeRange.MinValueSerializable = "0"
			xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
			Me.chartControlDistributions.Diagram = xyDiagram1
			Me.chartControlDistributions.Dock = System.Windows.Forms.DockStyle.Fill
			Me.chartControlDistributions.Location = New System.Drawing.Point(0, 0)
			Me.chartControlDistributions.Name = "chartControlDistributions"
			pointSeriesLabel1.LineVisible = True
			series1.Label = pointSeriesLabel1
			series1.Name = "Uniform Distribution"
			series1.View = pointSeriesView1
			pointSeriesLabel2.LineVisible = True
			series2.Label = pointSeriesLabel2
			series2.Name = "Normal Distribution"
			series2.View = pointSeriesView2
			pointSeriesLabel3.LineVisible = True
			series3.Label = pointSeriesLabel3
			series3.Name = "Exponential Distribution"
			series3.View = pointSeriesView3
			Me.chartControlDistributions.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1, series2, series3}
			pointSeriesLabel4.LineVisible = True
			Me.chartControlDistributions.SeriesTemplate.Label = pointSeriesLabel4
			Me.chartControlDistributions.SeriesTemplate.View = pointSeriesView4
			Me.chartControlDistributions.Size = New System.Drawing.Size(746, 495)
			Me.chartControlDistributions.TabIndex = 0
			chartTitle1.Text = "Uniform Distributions"
			Me.chartControlDistributions.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() { chartTitle1})
			' 
			' mainForm
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(746, 495)
			Me.Controls.Add(Me.chartControlDistributions)
			Me.Name = "mainForm"
			Me.Text = "Radio Buttons in Legend"
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(pointSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(pointSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(pointSeriesLabel2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(pointSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(pointSeriesLabel3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(pointSeriesView3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(pointSeriesLabel4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(pointSeriesView4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chartControlDistributions, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private chartControlDistributions As DevExpress.XtraCharts.ChartControl
	End Class
End Namespace

