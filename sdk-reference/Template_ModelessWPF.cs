using System;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.Attributes;
using csRevit.API;

namespace csRevit_Tools
{
    // 1. CREATE THE HANDLER (This executes code safely on Revit's main thread)
    public class MyModelessHandler : IExternalEventHandler
    {
        public void Execute(UIApplication app)
        {
            Document doc = app.ActiveUIDocument.Document;
            using (Transaction t = new Transaction(doc, "Modeless Modification"))
            {
                t.Start();
                // YOUR REVIT DB MODIFICATIONS GO HERE
                t.Commit();
            }
        }
        public string GetName() => "csRevit Modeless Handler";
    }

    // 2. CREATE THE BUTTON COMMAND
    [Transaction(TransactionMode.Manual)]
    public class LaunchModelessCommand : IExternalCommand
    {
        // Keep window static so only one instance opens at a time
        private static MyWpfWindow _modelessWindow = null; 

        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            if (_modelessWindow != null && _modelessWindow.IsLoaded)
            {
                _modelessWindow.Focus(); // Bring to front if already open
                return Result.Succeeded;
            }

            // Create Event and Handler
            MyModelessHandler handler = new MyModelessHandler();
            ExternalEvent exEvent = ExternalEvent.Create(handler);

            // Pass the Event into your WPF Window
            _modelessWindow = new MyWpfWindow(exEvent);

            var helper = new System.Windows.Interop.WindowInteropHelper(_modelessWindow);
            helper.Owner = System.Diagnostics.Process.GetCurrentProcess().MainWindowHandle;

            // Launch Modelessly (Revit remains active)
            _modelessWindow.Show();

            return Result.Succeeded;
        }
    }
}
