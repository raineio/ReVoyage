using Dalamud.Configuration;

namespace ReVoyage
{
    internal class Config : IPluginConfiguration
    {
        public int Version { get; set; } = 0;

        public bool Enabled = true;
    }
}
