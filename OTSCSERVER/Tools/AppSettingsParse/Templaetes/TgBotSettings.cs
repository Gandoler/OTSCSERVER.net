using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTSCSERVER.Tools.AppSettingsParse.Templaetes
{
    internal class TgBotSettings : ITemplates
    {
        [JsonProperty(nameof(Token))]
        public string Token { get; set; } = string.Empty;


        public string GetConnectionString()
        {
            return Token;    
        }
        public override string ToString()
        {
            return Token; 
        }

    }
}
