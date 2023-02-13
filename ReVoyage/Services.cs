using Dalamud.Game.Command;
using Dalamud.IoC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReVoyage
{
    internal class Services
    {
        internal static Config config { get; set; } = null!;

        [PluginService]
        internal static CommandManager commandManager { get; set; } = null!;
    }
}
