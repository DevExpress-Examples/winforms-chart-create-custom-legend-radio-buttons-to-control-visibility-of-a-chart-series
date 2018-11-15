<!-- default file list -->
*Files to look at*:

* [MainForm.cs](./CS/MainForm.cs) (VB: [MainForm.vb](./VB/MainForm.vb))
<!-- default file list end -->
# How to create custom legend radio buttons to control visibility of a chart series


<p>This example demonstrates how to show a series (Point, Line or Area) , depending on the selection state of a custom radio button in the chart legend. </p><br />



<h3>Description</h3>

<p>This example demonstrates how to show a distribution law (Normal, Uniform or Exponential) applied to series points, depending on the selection state of a custom radio button in the chart legend. </p><p><br />
Use the <strong>ChartControl.CustomDrawSeries</strong> event handler to create a custom appearance for radio buttons based on the color of a selected series.  </p><p><br />
To provide the capability for custom radio buttons to show (or hide) the series to which the distribution law belongs, use the<strong> LegendItemCheckedEventArgs.CheckedElement</strong> and <strong>SeriesBase.CheckedInLegend </strong>properties in the <strong>ChartControl.LegendItemChecked</strong> event.  </p>

<br/>


