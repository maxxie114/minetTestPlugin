using System;
using log4net;
using MiNET.Plugins;
using MiNET.Plugins.Attributes;
using MiNET;
using MiNET.Plugins.Commands;

namespace ExamplePlugin 
{
    [Plugin(PluginName = "ExamplePlugin", Description = "just a test plugin", PluginVersion = "1.0", Author = "Maxxie115")]
    public class ExamplePlugin : Plugin
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof (ExamplePlugin));
        protected override void OnEnable()
        {
            Log.Debug("Plugin enabled");
        }

        public override void OnDisable()
        {
            Log.Debug("Plugin disabled.");
        }

        [Command(Name="example")]
        public void example(Player player)
        {
            player.SendMessage("Hello world!");
        }

    }
}