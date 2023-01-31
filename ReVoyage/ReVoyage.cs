using Dalamud;
using Dalamud.Plugin;

namespace ReVoyage
{
    public class ReVoyage : IDalamudPlugin
    {
        public string Name => "ReVoyage";

        private readonly DalamudPluginInterface _dalamudPluginInterface;

        public ReVoyage(DalamudPluginInterface pluginInterface)
        {
            _dalamudPluginInterface = pluginInterface;
        }

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }
    }
}