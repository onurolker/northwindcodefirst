using Northwind.Helpers.Properties;

namespace Northwind.Helpers
{
    public class ConnectionTools
    {
        public static string ConnectionString
        {
            get
            {
                return Configuration.Default.connectionPath;
            }
        }
    }
}
