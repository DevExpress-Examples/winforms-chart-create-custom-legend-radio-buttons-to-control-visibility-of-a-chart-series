<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128574134/19.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4951)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MainForm.cs](./CS/MainForm.cs) (VB: [MainForm.vb](./VB/MainForm.vb))
<!-- default file list end -->
# How to create custom legend radio buttons to control visibility of a chart series


<p>This example demonstrates how to show a series (Point, Line or Area) , depending on the selection state of a custom radio button in the chart legend. </p><br />



<h3>Description</h3>

<p>Use the <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraChartsChartControl_CustomDrawSeriestopic"><u>ChartControl.CustomDrawSeries</u></a> event handler to create a custom appearance for radio buttons based on the color of a selected series.  <br />
</p><p>To provide the capability for custom radio buttons to show (or hide) the series, use the <a href="https://documentation.devexpress.com/#CoreLibraries/DevExpressXtraChartsLegendItemCheckedEventArgs_CheckedElementtopic"><u>LegendItemCheckedEventArgs.CheckedElement</u></a> and <a href="https://documentation.devexpress.com/#CoreLibraries/DevExpressXtraChartsSeriesBase_CheckedInLegendtopic"><u>SeriesBase.CheckedInLegend</u></a> properties in the <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraChartsChartControl_LegendItemCheckedtopic"><u>ChartControl.LegendItemChecked</u></a><u> </u>event.  </p><p><br />
</p>

<br/>


