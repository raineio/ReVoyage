using Dalamud;
using Dalamud.Plugin;
using System;

namespace ReVoyage
{
    public class ReVoyage : IDalamudPlugin
    {
        public string Name => "ReVoyage";

        private readonly DalamudPluginInterface _dalamudPluginInterface;

        public ReVoyage(DalamudPluginInterface pluginInterface)
        {
            _dalamudPluginInterface = pluginInterface;

            Main();
        }

        private static void Main()
        {
            Console.WriteLine("Hello, World from ReVoyage!");
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}