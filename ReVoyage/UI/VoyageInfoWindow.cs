using Dalamud.Interface.Windowing;
using ImGuiNET;
using System.Numerics;

namespace ReVoyage.UI
{
    internal class VoyageInfoWindow : Window
    {

        public VoyageInfoWindow() : base("Voyage Info", ImGuiWindowFlags.NoCollapse | ImGuiWindowFlags.NoResize | ImGuiWindowFlags.NoScrollbar)
        {
            this.Size = new Vector2(640, 480);
        }

        public override void Draw()
        {
            QuickUI.DrawCheckboxWithSeparator("Enable", Services.config.Enabled);

            QuickUI.DrawFreeCompanyVoyageInfo();
            QuickUI.DrawVoyageInfo();
        }
    }
}
