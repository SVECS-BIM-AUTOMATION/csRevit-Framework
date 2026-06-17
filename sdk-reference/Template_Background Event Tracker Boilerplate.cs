using Autodesk.Revit.DB;
using Autodesk.Revit.DB.Events;
using Autodesk.Revit.UI;
using csRevit.API;

namespace csRevit_Tools
{
    public class AutoAuditService : IExternalApplication
    {
        public Result OnStartup(UIControlledApplication app)
        {
            // Safely subscribe to Revit's native background events
            app.ControlledApplication.DocumentOpened += OnDocumentOpened;
            app.ControlledApplication.DocumentSaved += OnDocumentSaved;
            
            return Result.Succeeded;
        }

        public Result OnShutdown(UIControlledApplication app)
        {
            app.ControlledApplication.DocumentOpened -= OnDocumentOpened;
            app.ControlledApplication.DocumentSaved -= OnDocumentSaved;
            
            return Result.Succeeded;
        }

        private void OnDocumentOpened(object sender, DocumentOpenedEventArgs e)
        {
            Document doc = e.Document;
            if (doc.IsFamilyDocument) return;

            // YOUR SILENT BACKGROUND LOGIC HERE
            // Note: Background events cannot use standard UI TaskDialogs.
        }

        private void OnDocumentSaved(object sender, DocumentSavedEventArgs e)
        {
            Document doc = e.Document;
            // Execute save trackers or exports here...
        }
    }
}
