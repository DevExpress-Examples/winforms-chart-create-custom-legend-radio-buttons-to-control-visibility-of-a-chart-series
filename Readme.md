# How to create custom legend radio buttons to control visibility of a chart series


<p>This example demonstrates how to show a series (Point, Line or Area) , depending on the selection state of a custom radio button in the chart legend. </p><br />



<h3>Description</h3>

<p>Use the <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraChartsChartControl_CustomDrawSeriestopic"><u>ChartControl.CustomDrawSeries</u></a> event handler to create a custom appearance for radio buttons based on the color of a selected series.  <br />
</p><p>To provide the capability for custom radio buttons to show (or hide) the series, use the <a href="https://documentation.devexpress.com/#CoreLibraries/DevExpressXtraChartsLegendItemCheckedEventArgs_CheckedElementtopic"><u>LegendItemCheckedEventArgs.CheckedElement</u></a> and <a href="https://documentation.devexpress.com/#CoreLibraries/DevExpressXtraChartsSeriesBase_CheckedInLegendtopic"><u>SeriesBase.CheckedInLegend</u></a> properties in the <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraChartsChartControl_LegendItemCheckedtopic"><u>ChartControl.LegendItemChecked</u></a><u> </u>event.  </p><p><br />
</p>

<br/>


