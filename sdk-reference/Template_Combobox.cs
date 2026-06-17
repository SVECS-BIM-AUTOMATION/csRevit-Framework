using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.Attributes;
using csRevit.API; // Required for SettingsManager

namespace csRevit_Tools
{
    [Transaction(TransactionMode.Manual)]
    [DisplayName("Select Discipline")]
    public class DisciplineComboBoxCommand : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            // Read the value the user just selected from the Dropdown
            string selectedValue = SettingsManager.ReadSetting("Select Discipline", "ComboBoxValue", "");

            TaskDialog.Show("Combo Box", $"You selected: {selectedValue}");

            // Apply logic based on the selection...

            return Result.Succeeded;
        }
    }
}
