using Microsoft.Extensions.Options;

namespace ClientInventory.Utils
{
    public class AppSettings
    {
        public AppSettings() { }
        public AppSettings(IOptions<AppSettings> options)
        {
            ConnectionString = options.Value.ConnectionString;
            DBName = options.Value.DBName;
        }
        public string ConnectionString { get; set; }
        public string DBName { get; set; }
    }
}
