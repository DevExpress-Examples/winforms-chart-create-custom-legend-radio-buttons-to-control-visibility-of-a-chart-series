using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using DevExpress.XtraCharts;

namespace CustomCheckboxesInLegendViewAndBehavior {
    public partial class mainForm : Form {
        const int LegendRadioSide = 17;
        const int LegendRadioInnerPointBoundsSide = 8;
        const int PointsCount = 500;
        const int MinPointCoord = 0;
        const int MaxPointCoord = 100;
        const float LegendRadioWidth = 1.5f;
        const double ExponentialDistributionParameter = 2; //"Lambda"
        const double ThreeSD = 3;

        bool initializationFlag = false;

        public mainForm() {
            InitializeComponent();
            initializationFlag = true;
            chartControlDistributions.BeginInit();
            {                
                chartControlDistributions.Legend.UseCheckBoxes = true;
                chartControlDistributions.CustomDrawSeries += OnCustomDrawSeries;
                chartControlDistributions.LegendItemChecked += OnLegendItemChecked;
                chartControlDistributions.Series["Uniform Distribution"].CheckedInLegend = true;
                chartControlDistributions.Series["Normal Distribution"].CheckedInLegend = false;
                chartControlDistributions.Series["Exponential Distribution"].CheckedInLegend = false;
                SeriesPoint[] uniformDistributedPoints = CreateUniformDistributedPoints();
                chartControlDistributions.Series["Uniform Distribution"].Points.AddRange(uniformDistributedPoints);
                SeriesPoint[] normalDistributedPoints = CreateNormalDistributedPoints();
                chartControlDistributions.Series["Normal Distribution"].Points.AddRange(normalDistributedPoints);
                SeriesPoint[] exponentialDistributedPoints = CreateExponentialDistributedPoints(ExponentialDistributionParameter);
                chartControlDistributions.Series["Exponential Distribution"].Points.AddRange(exponentialDistributedPoints);
            }
            chartControlDistributions.EndInit();
            initializationFlag = false;
        }

        void OnLegendItemChecked(object sender, LegendItemCheckedEventArgs e) {
            if (initializationFlag == true)
                return;
            initializationFlag = true; {
                Series checkedSeries = e.CheckedElement as Series;
                if (checkedSeries == null)
                    throw new Exception("Expected series only");
                foreach (Series series in chartControlDistributions.Series)
                    series.CheckedInLegend = false;
                checkedSeries.CheckedInLegend = true;
                chartControlDistributions.Titles[0].Text = checkedSeries.Name;
            } initializationFlag = false;
        }

        void OnCustomDrawSeries(object sender, CustomDrawSeriesEventArgs e) {
            Bitmap bitmap = new Bitmap(LegendRadioSide, LegendRadioSide);
            using (Graphics graphics = Graphics.FromImage(bitmap)) {
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                Color seriesColor = GetSeriesColor(e.Series, chartControlDistributions);
                Pen radioPen = new Pen(seriesColor, LegendRadioWidth);
                int radioRadius = LegendRadioSide - 3;
                Rectangle radioRectangle = new Rectangle(1, 1, radioRadius, radioRadius);
                graphics.DrawEllipse(radioPen, radioRectangle);
                if (e.Series.CheckedInLegend) {
                    Brush brush = new SolidBrush(seriesColor);
                    int coord = (LegendRadioSide - LegendRadioInnerPointBoundsSide) / 2;
                    Rectangle filledEllipseBounds = new Rectangle(coord, coord, LegendRadioInnerPointBoundsSide, LegendRadioInnerPointBoundsSide);
                    graphics.FillEllipse(brush, filledEllipseBounds);
                }
            }
            e.DisposeLegendMarkerImage = true;
            e.LegendMarkerImage = bitmap;
        }
        Color GetSeriesColor(Series series, ChartControl chartControlDistributions) {
            int seriesIndex = chartControlDistributions.Series.IndexOf(series);
            string paletteName = chartControlDistributions.PaletteName;
            Palette currentPalette = chartControlDistributions.PaletteRepository[paletteName];
            PaletteEntry paletteEntryAccordingToSeries = currentPalette[seriesIndex];
            Color result = paletteEntryAccordingToSeries.Color;
            return result;
        }
        #region Data Generation
        SeriesPoint[] CreateExponentialDistributedPoints(double exponentialDistributionParameter) {
            SeriesPoint[] exponentialDistributedPoints = new SeriesPoint[PointsCount];
            Random rndX = new Random();
            Random rndY = new Random(1);
            for (int i = 0; i < PointsCount; i++) {
                double x = -1 / exponentialDistributionParameter * Math.Log(1 - rndX.NextDouble());
                double y = -1 / exponentialDistributionParameter * Math.Log(1 - rndY.NextDouble());
                x = x / ThreeSD * (MaxPointCoord - MinPointCoord);
                y = y / ThreeSD * (MaxPointCoord - MinPointCoord);
                exponentialDistributedPoints[i] = new SeriesPoint(x, y);
            }
            return exponentialDistributedPoints;
        }
        SeriesPoint[] CreateNormalDistributedPoints() {
            SeriesPoint[] normalDistributedPoints = new SeriesPoint[PointsCount];
            Random rndX = new Random();
            Random rndY = new Random(1);
            for (int i = 0; i < PointsCount; i += 2) {
                double s;
                double s1;
                double s2;
                do {
                    s1 = rndX.Next(-1000000, 1000000) / 1000000.0;
                    s2 = rndX.Next(-1000000, 1000000) / 1000000.0;
                    s = s1 * s1 + s2 * s2;
                } while (s > 1 || s < 0);
                double x1 = s1 * Math.Sqrt(-2 * Math.Log(s) / s);
                double x2 = s2 * Math.Sqrt(-2 * Math.Log(s) / s);
                x1 = (x1 - (-ThreeSD)) / (ThreeSD - (-ThreeSD)) * (MaxPointCoord - MinPointCoord);
                x2 = (x2 - (-ThreeSD)) / (ThreeSD - (-ThreeSD)) * (MaxPointCoord - MinPointCoord);
                double l;
                double l1;
                double l2;
                do {
                    l1 = rndX.Next(-1000000, 1000000) / 1000000.0;
                    l2 = rndX.Next(-1000000, 1000000) / 1000000.0;
                    l = l1 * l1 + l2 * l2;
                } while (l > 1 || l < 0);
                double y1 = l1 * Math.Sqrt(-2 * Math.Log(l) / l);
                double y2 = l2 * Math.Sqrt(-2 * Math.Log(l) / l);
                y1 = (y1 - (-ThreeSD)) / (ThreeSD - (-ThreeSD)) * (MaxPointCoord - MinPointCoord);
                y2 = (y2 - (-ThreeSD)) / (ThreeSD - (-ThreeSD)) * (MaxPointCoord - MinPointCoord);
                normalDistributedPoints[i] = new SeriesPoint(x1, y1);
                normalDistributedPoints[i + 1] = new SeriesPoint(x2, y2);
            }
            return normalDistributedPoints;
        }
        SeriesPoint[] CreateUniformDistributedPoints() {
            Random rndX = new Random();
            Random rndY = new Random(1);
            SeriesPoint[] points = new SeriesPoint[PointsCount];
            for (int i = 0; i < PointsCount; i++) {
                int x = rndX.Next(MinPointCoord, MaxPointCoord);
                int y = rndY.Next(MinPointCoord, MaxPointCoord);
                SeriesPoint dataPoint = new SeriesPoint(x, y);
                points[i] = dataPoint;
            }
            return points;
        }
        #endregion
    }
}
