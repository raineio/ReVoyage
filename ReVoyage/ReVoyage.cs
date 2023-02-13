using Dalamud;
using Dalamud.Plugin;
using Dalamud.Logging;
using System;
using Dalamud.Game.Command;
using ReVoyage.UI;
using Dalamud.Interface.Windowing;
using Dalamud.IoC;

namespace ReVoyage
{
    internal class ReVoyage : IDalamudPlugin
    {
        public string Name => "ReVoyage";

        private DalamudPluginInterface _dalamudPluginInterface;

        private readonly WindowSystem _windowSystem;
        private VoyageInfoWindow _voyageInfoWindow;

        public ReVoyage(DalamudPluginInterface pluginInterface)
        {
            _dalamudPluginInterface = pluginInterface;

            _dalamudPluginInterface.Create<Services>();

            Services.config = _dalamudPluginInterface.GetPluginConfig() as Config ?? new Config();

            Services.commandManager.AddHandler("/voyage", new CommandInfo(OnChat)
            {
                HelpMessage = "Opens the config window for ReVoyage",
                ShowInHelp = true
            });

            _voyageInfoWindow = new();
            _windowSystem = new("ReVoyage");
            _windowSystem.AddWindow(_voyageInfoWindow);

            _dalamudPluginInterface.UiBuilder.Draw += _windowSystem.Draw;

            // _dalamudPluginInterface.UiBuilder.
        }

        private static void Main()
        {
            PluginLog.Log("Hello, World from ReVoyage!");
        }

        private void OnChat(string command, string arguments)
        {
            PluginLog.LogDebug("Going to toggle UI");
            _voyageInfoWindow.Toggle();
            PluginLog.LogDebug("Toggled UI");
        }

        public void Dispose()
        {
            PluginLog.LogDebug("is not implemented :D");
        }
    }
}