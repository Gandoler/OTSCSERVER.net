using Newtonsoft.Json;

namespace OTSCSERVER.Tools.Templaetes
{
    internal class RootConfig : ITemplates
    {
        [JsonProperty("serverSetings")] 
        public required ServerSettings ServerSettings { get; set; } = new ServerSettings()!;




        public string GetConnectionString()
        {
            return ServerSettings?.ToString() ?? string.Empty;
        }

        public override string ToString()
        {
            return ServerSettings?.ToString() ?? string.Empty;
        }

    }
}
