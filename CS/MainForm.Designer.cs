namespace CustomCheckboxesInLegendViewAndBehavior {
    partial class mainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PointSeriesLabel pointSeriesLabel1 = new DevExpress.XtraCharts.PointSeriesLabel();
            DevExpress.XtraCharts.PointSeriesView pointSeriesView1 = new DevExpress.XtraCharts.PointSeriesView();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PointSeriesLabel pointSeriesLabel2 = new DevExpress.XtraCharts.PointSeriesLabel();
            DevExpress.XtraCharts.PointSeriesView pointSeriesView2 = new DevExpress.XtraCharts.PointSeriesView();
            DevExpress.XtraCharts.Series series3 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PointSeriesLabel pointSeriesLabel3 = new DevExpress.XtraCharts.PointSeriesLabel();
            DevExpress.XtraCharts.PointSeriesView pointSeriesView3 = new DevExpress.XtraCharts.PointSeriesView();
            DevExpress.XtraCharts.PointSeriesLabel pointSeriesLabel4 = new DevExpress.XtraCharts.PointSeriesLabel();
            DevExpress.XtraCharts.PointSeriesView pointSeriesView4 = new DevExpress.XtraCharts.PointSeriesView();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            this.chartControlDistributions = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.chartControlDistributions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesView4)).BeginInit();
            this.SuspendLayout();
            // 
            // chartControlDistributions
            // 
            xyDiagram1.AxisX.VisualRange.Auto = false;
            xyDiagram1.AxisX.VisualRange.MaxValueSerializable = "100";
            xyDiagram1.AxisX.VisualRange.MinValueSerializable = "0";
            xyDiagram1.AxisX.WholeRange.MaxValueSerializable = "100";
            xyDiagram1.AxisX.WholeRange.MinValueSerializable = "0";
            xyDiagram1.AxisX.WholeRange.AutoSideMargins = false;
            xyDiagram1.AxisX.VisualRange.AutoSideMargins = false;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.VisualRange.Auto = false;
            xyDiagram1.AxisY.VisualRange.MaxValueSerializable = "100";
            xyDiagram1.AxisY.VisualRange.MinValueSerializable = "0";
            xyDiagram1.AxisY.WholeRange.MaxValueSerializable = "100";
            xyDiagram1.AxisY.WholeRange.MinValueSerializable = "0";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControlDistributions.Diagram = xyDiagram1;
            this.chartControlDistributions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControlDistributions.Location = new System.Drawing.Point(0, 0);
            this.chartControlDistributions.Name = "chartControlDistributions";
            pointSeriesLabel1.LineVisible = true;
            series1.Label = pointSeriesLabel1;
            series1.Name = "Uniform Distribution";
            series1.View = pointSeriesView1;
            pointSeriesLabel2.LineVisible = true;
            series2.Label = pointSeriesLabel2;
            series2.Name = "Normal Distribution";
            series2.View = pointSeriesView2;
            pointSeriesLabel3.LineVisible = true;
            series3.Label = pointSeriesLabel3;
            series3.Name = "Exponential Distribution";
            series3.View = pointSeriesView3;
            this.chartControlDistributions.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1,
        series2,
        series3};
            pointSeriesLabel4.LineVisible = true;
            this.chartControlDistributions.SeriesTemplate.Label = pointSeriesLabel4;
            this.chartControlDistributions.SeriesTemplate.View = pointSeriesView4;
            this.chartControlDistributions.Size = new System.Drawing.Size(746, 495);
            this.chartControlDistributions.TabIndex = 0;
            chartTitle1.Text = "Uniform Distributions";
            this.chartControlDistributions.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 495);
            this.Controls.Add(this.chartControlDistributions);
            this.Name = "mainForm";
            this.Text = "Radio Buttons in Legend";
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControlDistributions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraCharts.ChartControl chartControlDistributions;
    }
}

