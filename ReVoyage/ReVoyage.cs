using Dalamud;
using Dalamud.Plugin;
using Dalamud.Logging;
using System;
using Dalamud.Game.Command;
using ReVoyage.UI;
using Dalamud.Interface.Windowing;

namespace ReVoyage
{
    internal class ReVoyage : IDalamudPlugin
    {
        public string Name => "ReVoyage";

        private readonly DalamudPluginInterface _dalamudPluginInterface;
        private readonly CommandManager _commandManager;

        private readonly WindowSystem _windowSystem;

        private Config _config;
        private ConfigUI _configUI;

        public ReVoyage(DalamudPluginInterface pluginInterface, Config config)
        {
            _dalamudPluginInterface = pluginInterface;
            _config = config;

            _commandManager.AddHandler("/voyage", new CommandInfo(this.OnChat)
            {
                HelpMessage = "",
                ShowInHelp = true
            });

            this._configUI = new();
            this._windowSystem = new("ReVoyage");

            Main();
        }

        private static void Main()
        {
            PluginLog.Log("Hello, World from ReVoyage!");
        }

        private void OnChat()
        {
            this._configUI.Toggle();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}