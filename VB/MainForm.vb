Imports System
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
Imports DevExpress.XtraCharts

Namespace CustomCheckboxesInLegendViewAndBehavior

    Public Partial Class mainForm
        Inherits Form

        Const LegendRadioSide As Integer = 17

        Const LegendRadioInnerPointBoundsSide As Integer = 8

        Const LegendRadioWidth As Single = 1.5F

        Private initializationFlag As Boolean = False

        Public Sub New()
            InitializeComponent()
            chartControl.BeginInit()
            If True Then
                AddHandler chartControl.LegendItemChecked, AddressOf OnLegendItemChecked
                AddHandler chartControl.CustomDrawSeries, AddressOf OnCustomDrawSeries
                chartControl.Legend.UseCheckBoxes = True
                chartControl.Series("Point").CheckedInLegend = False
                chartControl.Series("Line").CheckedInLegend = True
                chartControl.Series("Area").CheckedInLegend = False
            End If

            chartControl.EndInit()
            initializationFlag = False
        End Sub

        Private Sub OnLegendItemChecked(ByVal sender As Object, ByVal e As LegendItemCheckedEventArgs)
            If initializationFlag = True Then Return
            initializationFlag = True
            If True Then
                Dim checkedSeries As Series = TryCast(e.CheckedElement, Series)
                If checkedSeries Is Nothing Then Throw New Exception("Expected series only")
                For Each series As Series In chartControl.Series
                    series.CheckedInLegend = False
                Next

                checkedSeries.CheckedInLegend = True
                chartControl.Titles(0).Text = checkedSeries.Name
            End If

            initializationFlag = False
        End Sub

        Private Sub OnCustomDrawSeries(ByVal sender As Object, ByVal e As CustomDrawSeriesEventArgs)
            Dim bitmap As Bitmap = New Bitmap(LegendRadioSide, LegendRadioSide)
            Using graphics As Graphics = Graphics.FromImage(bitmap)
                graphics.SmoothingMode = SmoothingMode.HighQuality
                Dim seriesColor As Color = GetSeriesColor(e.Series, chartControl)
                Using radioPen As Pen = New Pen(seriesColor, LegendRadioWidth)
                    Dim radioRadius As Integer = LegendRadioSide - 3
                    Dim radioRectangle As Rectangle = New Rectangle(1, 1, radioRadius, radioRadius)
                    graphics.DrawEllipse(radioPen, radioRectangle)
                End Using

                If e.Series.CheckedInLegend Then
                    Using brush As Brush = New SolidBrush(seriesColor)
                        Dim coord As Integer =(LegendRadioSide - LegendRadioInnerPointBoundsSide) \ 2
                        Dim filledEllipseBounds As Rectangle = New Rectangle(coord, coord, LegendRadioInnerPointBoundsSide, LegendRadioInnerPointBoundsSide)
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
