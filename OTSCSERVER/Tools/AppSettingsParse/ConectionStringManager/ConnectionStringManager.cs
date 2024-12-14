using OTSCSERVER;
using OTSCSERVER.Tools.AppSettingsParse.Reader;
using OTSCSERVER.Tools.AppSettingsParse.Templaetes;
using Serilog;

namespace OTSCSERVER.Tools.AppSettingsParse.ConectionStringManager
{
    internal static class ConnectionStringManager
    {
        static RootConfig rootConfig = new(new ServerSettings(), new TgBotSettings());

        static ConnectionStringManager()
        {
            GoDeserialiseObject();
        }
        private static void GoDeserialiseObject()
        {

            JsonReaderForConfig jsonReader = new();
            try
            {
                rootConfig = jsonReader.Read<RootConfig>(ProgramSettings.Default.AppsettingsPath);
                Log.Information($"ConnectionStringManager: settings:{rootConfig}");
            }
            catch (Exception ex)
            {
                Log.Error($"In ConnectionStringManager {ex.Message}");
            }

        }

        public static string? GetConnectionString()
        {
            if (rootConfig.ServerSettings != null)
            {
                return rootConfig.ServerSettings.GetConnectionString();
            }
            return null;
        }


    }
}
