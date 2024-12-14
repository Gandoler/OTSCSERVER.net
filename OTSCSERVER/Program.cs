

using Serilog;

namespace OTSCSERVER
{
    internal static class Program
    {
        static void Main()
        {
            Log.Logger = new LoggerConfiguration()
               .WriteTo.File("C:/Users/glkru/OneDrive/Desktop/prj/Project_cpo/User_setup/Properties/logs/myapp.log", rollingInterval: RollingInterval.Day)
               .CreateLogger();
            Log.Information("App start");



            Log.Information("App stop");
            Log.CloseAndFlush();

        }


    }
}