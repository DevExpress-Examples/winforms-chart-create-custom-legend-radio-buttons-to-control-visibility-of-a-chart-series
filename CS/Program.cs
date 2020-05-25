// Developer Express Code Central Example:
// How to create custom legend radio buttons to control visibility of a chart series
// 
// This example demonstrates how to show a distribution law (Normal, Uniform or
// Exponential) applied to series points, depending on the selection state of a
// custom radio button in the chart legend.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E4951

using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CustomCheckboxesInLegendViewAndBehavior {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            WindowsFormsSettings.SetDPIAware();
            WindowsFormsSettings.AllowDpiScale = true;
            WindowsFormsSettings.AllowAutoScale = DevExpress.Utils.DefaultBoolean.True;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new mainForm());
        }
    }
}
