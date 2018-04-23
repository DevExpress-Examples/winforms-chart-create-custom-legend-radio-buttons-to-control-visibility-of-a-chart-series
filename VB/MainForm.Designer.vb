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
            Dim XyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
            Dim Series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim SeriesPoint1 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("1", New Object() {CType(3.0R, Object)})
            Dim SeriesPoint2 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("2", New Object() {CType(12.0R, Object)})
            Dim SeriesPoint3 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("3", New Object() {CType(16.0R, Object)})
            Dim SeriesPoint4 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("4", New Object() {CType(21.0R, Object)})
            Dim PointSeriesView As DevExpress.XtraCharts.PointSeriesView = New DevExpress.XtraCharts.PointSeriesView()
            Dim Series2 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim SeriesPoint5 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("1", New Object() {CType(2.0R, Object)})
            Dim SeriesPoint6 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("2", New Object() {CType(12.0R, Object)})
            Dim SeriesPoint7 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("3", New Object() {CType(25.0R, Object)})
            Dim SeriesPoint8 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("4", New Object() {CType(35.0R, Object)})
            Dim LineSeriesView As DevExpress.XtraCharts.LineSeriesView = New DevExpress.XtraCharts.LineSeriesView()
            Dim Series3 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim SeriesPoint9 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("1", New Object() {CType(15.0R, Object)})
            Dim SeriesPoint10 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("2", New Object() {CType(18.0R, Object)})
            Dim SeriesPoint11 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("3", New Object() {CType(25.0R, Object)})
            Dim SeriesPoint12 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("4", New Object() {CType(33.0R, Object)})
            Dim AreaSeriesView As DevExpress.XtraCharts.AreaSeriesView = New DevExpress.XtraCharts.AreaSeriesView()
            Dim ChartTitle1 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Me.chartControl = New DevExpress.XtraCharts.ChartControl()
            CType(Me.chartControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(XyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Series1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(PointSeriesView, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Series2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(LineSeriesView, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Series3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(AreaSeriesView, System.ComponentModel.ISupportInitialize).BeginInit()
            '
            'chartControlDistributions
            '

            Me.chartControl.Diagram = XyDiagram1
            Me.chartControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chartControl.Location = New System.Drawing.Point(0, 0)
            Me.chartControl.Name = "chartControl"
            Series1.Name = "Point"
            Series1.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() {SeriesPoint1, SeriesPoint2, SeriesPoint3, SeriesPoint4})
            Series1.View = PointSeriesView
            Series2.Name = "Line"
            Series2.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() {SeriesPoint5, SeriesPoint6, SeriesPoint7, SeriesPoint8})
            Series2.View = LineSeriesView
            Series3.Name = "Area"
            Series3.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() {SeriesPoint9, SeriesPoint10, SeriesPoint11, SeriesPoint12})
            Series3.View = AreaSeriesView
            Me.chartControl.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series1, Series2, Series3}
            Me.chartControl.Size = New System.Drawing.Size(746, 495)
            Me.chartControl.TabIndex = 0
            ChartTitle1.Text = "Custom Radio Buttons"
            Me.chartControl.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle1})
            '
            'mainForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(746, 495)
            Me.Controls.Add(Me.chartControl)
            Me.Name = "mainForm"
            Me.Text = "Radio Buttons in Legend"
            CType(XyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(PointSeriesView, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Series1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(LineSeriesView, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Series2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(AreaSeriesView, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Series3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.chartControl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

		#End Region

        Private chartControl As DevExpress.XtraCharts.ChartControl
	End Class
End Namespace

