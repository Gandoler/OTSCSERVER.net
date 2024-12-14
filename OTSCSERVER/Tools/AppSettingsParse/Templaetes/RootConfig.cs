using Newtonsoft.Json;

namespace OTSCSERVER.Tools.AppSettingsParse.Templaetes
{
    internal class RootConfig(ServerSettings serverSettings, TgBotSettings tgBotSettings) : ITemplates
    {
        [JsonProperty("serverSetings")]
        public ServerSettings ServerSettings { get; set; } = serverSettings ?? new ServerSettings();
        [JsonProperty("botSettings")]
        public TgBotSettings TgBotSettings { get; set; } = tgBotSettings ?? new TgBotSettings();

        public string GetConnectionString()
        {
            return ServerSettings.ToString() + TgBotSettings.ToString();
        }

        public override string ToString()
        {
            return ServerSettings.ToString() ;
        }

    }
}
