using Dalamud.Interface.Windowing;
using ImGuiNET;
using System.Numerics;

namespace ReVoyage.UI
{
    internal class ConfigUI : Window
    {
        private Config _config;

        public ConfigUI() : base("ReVoyage Config Window", ImGuiWindowFlags.NoCollapse | ImGuiWindowFlags.NoResize | ImGuiWindowFlags.NoScrollbar) => this.Size = new Vector2(150, 150);

        public override void Draw()
        {
            ImGui.Checkbox("Enable", ref _config.Enabled);
        }
    }
}
