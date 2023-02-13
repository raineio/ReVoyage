using Dalamud.Game.Gui.PartyFinder.Types;
using ImGuiNET;
using ReVoyage.Models;

namespace ReVoyage.UI
{
    internal static class QuickUI
    {
        internal static void DrawCheckboxWithSeparator(string text, bool target)
        {
            ImGui.Text(text);
            ImGui.Separator();
            ImGui.Checkbox("", ref target);
        }

        internal static void DrawFreeCompanyVoyageInfo()
        {
            bool sub = false;
            bool air = true;

            string fcName = "Lost Survivors";
            string airshipName = "AS Fynd";

            if (air)
            {
                ImGui.Text($"Airship Found: {airshipName}");
            } 
            else
            {
                ImGui.Text("No Airship found in Free Company");
            }

            if (sub)
            {
                ImGui.Text($"Submarine Found: {airshipName}");
            } 
            else
            {
                ImGui.Text("¨No Submarine found in Free Company");
            }
        }

        internal static void DrawVoyageInfo()
        {
            ImGui.Text("Voyage Type: ");
            ImGui.Text("Voyage time: ");
        }
    }
}
