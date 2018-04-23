Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
Imports DevExpress.XtraCharts

Namespace CustomCheckboxesInLegendViewAndBehavior
	Partial Public Class mainForm
		Inherits Form
		Private Const LegendRadioSide As Integer = 17
		Private Const LegendRadioInnerPointBoundsSide As Integer = 8
		Private Const PointsCount As Integer = 500
		Private Const MinPointCoord As Integer = 0
		Private Const MaxPointCoord As Integer = 100
		Private Const LegendRadioWidth As Single = 1.5f
		Private Const ExponentialDistributionParameter As Double = 2 '"Lambda"
		Private Const ThreeSD As Double = 3

		Private initializationFlag As Boolean = False

		Public Sub New()
			InitializeComponent()
			initializationFlag = True
			chartControlDistributions.BeginInit()
				chartControlDistributions.Legend.UseCheckBoxes = True
				AddHandler chartControlDistributions.CustomDrawSeries, AddressOf OnCustomDrawSeries
				AddHandler chartControlDistributions.LegendItemChecked, AddressOf OnLegendItemChecked
				chartControlDistributions.Series("Uniform Distribution").CheckedInLegend = True
				chartControlDistributions.Series("Normal Distribution").CheckedInLegend = False
				chartControlDistributions.Series("Exponential Distribution").CheckedInLegend = False
				Dim uniformDistributedPoints() As SeriesPoint = CreateUniformDistributedPoints()
				chartControlDistributions.Series("Uniform Distribution").Points.AddRange(uniformDistributedPoints)
				Dim normalDistributedPoints() As SeriesPoint = CreateNormalDistributedPoints()
				chartControlDistributions.Series("Normal Distribution").Points.AddRange(normalDistributedPoints)
				Dim exponentialDistributedPoints() As SeriesPoint = CreateExponentialDistributedPoints(ExponentialDistributionParameter)
				chartControlDistributions.Series("Exponential Distribution").Points.AddRange(exponentialDistributedPoints)
			chartControlDistributions.EndInit()
			initializationFlag = False
		End Sub

		Private Sub OnLegendItemChecked(ByVal sender As Object, ByVal e As LegendItemCheckedEventArgs)
			If initializationFlag = True Then
				Return
			End If
			initializationFlag = True
				Dim checkedSeries As Series = TryCast(e.CheckedElement, Series)
				If checkedSeries Is Nothing Then
					Throw New Exception("Expected series only")
				End If
				For Each series As Series In chartControlDistributions.Series
					series.CheckedInLegend = False
				Next series
				checkedSeries.CheckedInLegend = True
				chartControlDistributions.Titles(0).Text = checkedSeries.Name
			initializationFlag = False
		End Sub

		Private Sub OnCustomDrawSeries(ByVal sender As Object, ByVal e As CustomDrawSeriesEventArgs)
			Dim bitmap As New Bitmap(LegendRadioSide, LegendRadioSide)
			Using graphics As Graphics = Graphics.FromImage(bitmap)
				graphics.SmoothingMode = SmoothingMode.HighQuality
				Dim seriesColor As Color = GetSeriesColor(e.Series, chartControlDistributions)
				Dim radioPen As New Pen(seriesColor, LegendRadioWidth)
				Dim radioRadius As Integer = LegendRadioSide - 3
				Dim radioRectangle As New Rectangle(1, 1, radioRadius, radioRadius)
				graphics.DrawEllipse(radioPen, radioRectangle)
				If e.Series.CheckedInLegend Then
					Dim brush As Brush = New SolidBrush(seriesColor)
					Dim coord As Integer = (LegendRadioSide - LegendRadioInnerPointBoundsSide) / 2
					Dim filledEllipseBounds As New Rectangle(coord, coord, LegendRadioInnerPointBoundsSide, LegendRadioInnerPointBoundsSide)
					graphics.FillEllipse(brush, filledEllipseBounds)
				End If
			End Using
			e.DisposeLegendMarkerImage = True
			e.LegendMarkerImage = bitmap
		End Sub
		Private Function GetSeriesColor(ByVal series As Series, ByVal chartControlDistributions As ChartControl) As Color
			Dim seriesIndex As Integer = chartControlDistributions.Series.IndexOf(series)
			Dim paletteName As String = chartControlDistributions.PaletteName
			Dim currentPalette As Palette = chartControlDistributions.PaletteRepository(paletteName)
			Dim paletteEntryAccordingToSeries As PaletteEntry = currentPalette(seriesIndex)
			Dim result As Color = paletteEntryAccordingToSeries.Color
			Return result
		End Function
		#Region "Data Generation"
		Private Function CreateExponentialDistributedPoints(ByVal exponentialDistributionParameter As Double) As SeriesPoint()
			Dim exponentialDistributedPoints(PointsCount - 1) As SeriesPoint
			Dim rndX As New Random()
			Dim rndY As New Random(1)
			For i As Integer = 0 To PointsCount - 1
				Dim x As Double = -1 / exponentialDistributionParameter * Math.Log(1 - rndX.NextDouble())
				Dim y As Double = -1 / exponentialDistributionParameter * Math.Log(1 - rndY.NextDouble())
				x = x / ThreeSD * (MaxPointCoord - MinPointCoord)
				y = y / ThreeSD * (MaxPointCoord - MinPointCoord)
				exponentialDistributedPoints(i) = New SeriesPoint(x, y)
			Next i
			Return exponentialDistributedPoints
		End Function
		Private Function CreateNormalDistributedPoints() As SeriesPoint()
			Dim normalDistributedPoints(PointsCount - 1) As SeriesPoint
			Dim rndX As New Random()
			Dim rndY As New Random(1)
			For i As Integer = 0 To PointsCount - 1 Step 2
				Dim s As Double
				Dim s1 As Double
				Dim s2 As Double
				Do
					s1 = rndX.Next(-1000000, 1000000) / 1000000.0
					s2 = rndX.Next(-1000000, 1000000) / 1000000.0
					s = s1 * s1 + s2 * s2
				Loop While s > 1 OrElse s < 0
				Dim x1 As Double = s1 * Math.Sqrt(-2 * Math.Log(s) / s)
				Dim x2 As Double = s2 * Math.Sqrt(-2 * Math.Log(s) / s)
				x1 = (x1 - (-ThreeSD)) / (ThreeSD - (-ThreeSD)) * (MaxPointCoord - MinPointCoord)
				x2 = (x2 - (-ThreeSD)) / (ThreeSD - (-ThreeSD)) * (MaxPointCoord - MinPointCoord)
				Dim l As Double
				Dim l1 As Double
				Dim l2 As Double
				Do
					l1 = rndX.Next(-1000000, 1000000) / 1000000.0
					l2 = rndX.Next(-1000000, 1000000) / 1000000.0
					l = l1 * l1 + l2 * l2
				Loop While l > 1 OrElse l < 0
				Dim y1 As Double = l1 * Math.Sqrt(-2 * Math.Log(l) / l)
				Dim y2 As Double = l2 * Math.Sqrt(-2 * Math.Log(l) / l)
				y1 = (y1 - (-ThreeSD)) / (ThreeSD - (-ThreeSD)) * (MaxPointCoord - MinPointCoord)
				y2 = (y2 - (-ThreeSD)) / (ThreeSD - (-ThreeSD)) * (MaxPointCoord - MinPointCoord)
				normalDistributedPoints(i) = New SeriesPoint(x1, y1)
				normalDistributedPoints(i + 1) = New SeriesPoint(x2, y2)
			Next i
			Return normalDistributedPoints
		End Function
		Private Function CreateUniformDistributedPoints() As SeriesPoint()
			Dim rndX As New Random()
			Dim rndY As New Random(1)
			Dim points(PointsCount - 1) As SeriesPoint
			For i As Integer = 0 To PointsCount - 1
				Dim x As Integer = rndX.Next(MinPointCoord, MaxPointCoord)
				Dim y As Integer = rndY.Next(MinPointCoord, MaxPointCoord)
				Dim dataPoint As New SeriesPoint(x, y)
				points(i) = dataPoint
			Next i
			Return points
		End Function
		#End Region
	End Class
End Namespace
