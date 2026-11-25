namespace LogiRoute
{
    public static class sqlServer
    {
        private static string connectionString = "Data Source=partex.database.windows.net;Initial Catalog=LogiRoute;User ID=CloudSA5c0f1ba1;Password=client#1@covitro;Trust Server Certificate=True;";


        public static string getConnectionString()
        {
            return connectionString;
        }
    }
}
