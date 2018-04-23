
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using DevExpress.XtraCharts;

namespace CustomCheckboxesInLegendViewAndBehavior {
    public partial class mainForm : Form {
        const int LegendRadioSide = 17;
        const int LegendRadioInnerPointBoundsSide = 8;
        const float LegendRadioWidth = 1.5f;
        bool initializationFlag = false;

        public mainForm() {
            InitializeComponent();
            chartControl.BeginInit();
            {
                chartControl.LegendItemChecked += OnLegendItemChecked;
                chartControl.CustomDrawSeries += OnCustomDrawSeries;
                chartControl.Legend.UseCheckBoxes = true;
                chartControl.Series["Point"].CheckedInLegend = false;
                chartControl.Series["Line"].CheckedInLegend = true;
                chartControl.Series["Area"].CheckedInLegend = false;
            }
            chartControl.EndInit();
            initializationFlag = false;
        }

        void OnLegendItemChecked(object sender, LegendItemCheckedEventArgs e) {
            if (initializationFlag == true)
                return;
            initializationFlag = true;
            {
                Series checkedSeries = e.CheckedElement as Series;
                if (checkedSeries == null)
                    throw new Exception("Expected series only");
                foreach (Series series in chartControl.Series)
                    series.CheckedInLegend = false;
                checkedSeries.CheckedInLegend = true;
                chartControl.Titles[0].Text = checkedSeries.Name;
            }
            initializationFlag = false;
        }

        void OnCustomDrawSeries(object sender, CustomDrawSeriesEventArgs e) {
            Bitmap bitmap = new Bitmap(LegendRadioSide, LegendRadioSide);
            using (Graphics graphics = Graphics.FromImage(bitmap)) {
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                Color seriesColor = GetSeriesColor(e.Series, chartControl);
                Pen radioPen = new Pen(seriesColor, LegendRadioWidth);
                int radioRadius = LegendRadioSide - 3;
                Rectangle radioRectangle = new Rectangle(1, 1, radioRadius, radioRadius);
                graphics.DrawEllipse(radioPen, radioRectangle);
                if (e.Series.CheckedInLegend) {
                    Brush brush = new SolidBrush(seriesColor);
                    int coord = (LegendRadioSide - LegendRadioInnerPointBoundsSide) / 2;
                    Rectangle filledEllipseBounds = new Rectangle(coord, coord,
                          LegendRadioInnerPointBoundsSide, LegendRadioInnerPointBoundsSide);
                    graphics.FillEllipse(brush, filledEllipseBounds);
                }
            }
            e.DisposeLegendMarkerImage = true;
            e.LegendMarkerImage = bitmap;
        }

        Color GetSeriesColor(Series series, ChartControl chartControl) {
            int seriesIndex = chartControl.Series.IndexOf(series);
            string paletteName = chartControl.PaletteName;
            Palette currentPalette = chartControl.PaletteRepository[paletteName];
            PaletteEntry paletteEntryAccordingToSeries = currentPalette[seriesIndex];
            Color result = paletteEntryAccordingToSeries.Color;
            return result;
        }
    }
}
