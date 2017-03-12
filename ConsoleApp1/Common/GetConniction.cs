using System.Configuration;
using System.Data.SqlClient;

namespace ConsoleApp1
{
    internal static class GetConniction
    {
        internal static SqlConnection Connections(ConnectionTypes connectionType)
        {
            switch (connectionType)
            {
                case ConnectionTypes.Tip:
                    return GetRepConniction();
                default:
                    return new SqlConnection();
            }
        }

        internal static SqlConnection GetRepConniction()
        {
            return new SqlConnection(ConfigurationManager.ConnectionStrings["RepConnection"].ConnectionString);
        }
    }
}