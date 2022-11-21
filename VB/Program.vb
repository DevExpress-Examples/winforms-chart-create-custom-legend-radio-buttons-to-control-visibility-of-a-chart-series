Imports System
Imports System.Windows.Forms

Namespace CustomCheckboxesInLegendViewAndBehavior

    Friend Module Program

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread>
        Sub Main()
            Call Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            Call Application.Run(New mainForm())
        End Sub
    End Module
End Namespace
