Imports System
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
Imports DevExpress.Drawing
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
            initializationFlag = True
            chartControl.BeginInit()
            chartControl.Legend.UseCheckBoxes = True
            AddHandler chartControl.CustomDrawSeries, AddressOf OnCustomDrawSeries
            AddHandler chartControl.LegendItemChecked, AddressOf OnLegendItemChecked
            chartControl.Series("Point").CheckedInLegend = True
            chartControl.Series("Line").CheckedInLegend = False
            chartControl.Series("Area").CheckedInLegend = False
            chartControl.EndInit()
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
            For Each series As Series In chartControl.Series
                series.CheckedInLegend = False
            Next series
            checkedSeries.CheckedInLegend = True
            chartControl.Titles(0).Text = checkedSeries.Name
            initializationFlag = False
        End Sub

        Private Sub OnCustomDrawSeries(ByVal sender As Object, ByVal e As CustomDrawSeriesEventArgs)
            Dim bitmap As New DXBitmap(LegendRadioSide, LegendRadioSide)
            Using graphics As DXGraphics = DXGraphics.FromImage(bitmap)
                graphics.SmoothingMode = DXSmoothingMode.HighQuality
                Dim seriesColor As Color = GetSeriesColor(e.Series, chartControl)
                Using radioPen As New DXPen(seriesColor, LegendRadioWidth)
                    Dim radioRadius As Integer = LegendRadioSide - 3
                    Dim radioRectangle As New Rectangle(1, 1, radioRadius, radioRadius)
                    graphics.DrawEllipse(radioPen, radioRectangle)
                End Using
                If e.Series.CheckedInLegend Then
                    Using brush As DXBrush = New DXSolidBrush(seriesColor)
                        Dim coord As Integer = (LegendRadioSide - LegendRadioInnerPointBoundsSide) / 2
                        Dim filledEllipseBounds As New Rectangle(coord, coord, LegendRadioInnerPointBoundsSide, LegendRadioInnerPointBoundsSide)
                        graphics.FillEllipse(brush, filledEllipseBounds)
                    End Using
                End If
            End Using
            e.DisposeLegendMarkerImage = True
            e.DXLegendMarkerImage = bitmap
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
