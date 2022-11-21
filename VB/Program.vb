' Developer Express Code Central Example:
' How to create custom legend radio buttons to control visibility of a chart series
' 
' This example demonstrates how to show a distribution law (Normal, Uniform or
' Exponential) applied to series points, depending on the selection state of a
' custom radio button in the chart legend.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E4951
Imports DevExpress.XtraEditors
Imports System
Imports System.Windows.Forms

Namespace CustomCheckboxesInLegendViewAndBehavior

    Friend Module Program

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread>
        Sub Main()
            Call WindowsFormsSettings.SetDPIAware()
            WindowsFormsSettings.AllowDpiScale = True
            WindowsFormsSettings.AllowAutoScale = DevExpress.Utils.DefaultBoolean.True
            Call Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            Call Application.Run(New mainForm())
        End Sub
    End Module
End Namespace
