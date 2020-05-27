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
		Private Const LegendRadioWidth As Single = 1.5F
		Private initializationFlag As Boolean = False

		Public Sub New()
			InitializeComponent()
'INSTANT VB TODO TASK: Local functions are not converted by Instant VB:
'			chartControl.BeginInit()
'			{
'				chartControl.LegendItemChecked += OnLegendItemChecked;
'				chartControl.CustomDrawSeries += OnCustomDrawSeries;
'				chartControl.Legend.UseCheckBoxes = True;
'				chartControl.Series["Point"].CheckedInLegend = False;
'				chartControl.Series["Line"].CheckedInLegend = True;
'				chartControl.Series["Area"].CheckedInLegend = False;
'			}
			chartControl.EndInit()
			initializationFlag = False
		End Sub

		Private Sub OnLegendItemChecked(ByVal sender As Object, ByVal e As LegendItemCheckedEventArgs)
			If initializationFlag = True Then
				Return
			End If
'INSTANT VB TODO TASK: Local functions are not converted by Instant VB:
'			initializationFlag = True
'			{
'				Series checkedSeries = TryCast(e.CheckedElement, Series);
'				if (checkedSeries == Nothing)
'					throw New Exception("Expected series only");
'				foreach (Series series in chartControl.Series)
'					series.CheckedInLegend = False;
'				checkedSeries.CheckedInLegend = True;
'				chartControl.Titles[0].Text = checkedSeries.Name;
'			}
			initializationFlag = False
		End Sub

		Private Sub OnCustomDrawSeries(ByVal sender As Object, ByVal e As CustomDrawSeriesEventArgs)
			Dim bitmap As New Bitmap(LegendRadioSide, LegendRadioSide)
			Using graphics As Graphics = System.Drawing.Graphics.FromImage(bitmap)
				graphics.SmoothingMode = SmoothingMode.HighQuality
				Dim seriesColor As Color = GetSeriesColor(e.Series, chartControl)
				Using radioPen As New Pen(seriesColor, LegendRadioWidth)
					Dim radioRadius As Integer = LegendRadioSide - 3
					Dim radioRectangle As New Rectangle(1, 1, radioRadius, radioRadius)
					graphics.DrawEllipse(radioPen, radioRectangle)
				End Using
				If e.Series.CheckedInLegend Then
					Using brush As Brush = New SolidBrush(seriesColor)
						Dim coord As Integer = (LegendRadioSide - LegendRadioInnerPointBoundsSide) \ 2
						Dim filledEllipseBounds As New Rectangle(coord, coord, LegendRadioInnerPointBoundsSide, LegendRadioInnerPointBoundsSide)
						graphics.FillEllipse(brush, filledEllipseBounds)
					End Using
				End If
			End Using
			e.DisposeLegendMarkerImage = True
			e.LegendMarkerImage = bitmap
		End Sub

		Private Function GetSeriesColor(ByVal series As Series, ByVal chartControl As ChartControl) As Color
			Dim seriesIndex As Integer = chartControl.Series.IndexOf(series)
			Dim paletteName As String = chartControl.PaletteName
			Dim currentPalette As Palette = chartControl.PaletteRepository(paletteName)
			Dim paletteEntryAccordingToSeries As PaletteEntry = currentPalette(seriesIndex)
			Dim result As Color = paletteEntryAccordingToSeries.Color
			Return result
		End Function
	End Class
End Namespace
