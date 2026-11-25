using Microsoft.Data.SqlClient;
using System.Data;

namespace LogiRoute
{
    public class DbManagement
    {
        public static DataTable GetData(string tableName, string? whereClause = "")
        {
            DataTable dt = new DataTable();

            using (SqlConnection con = new SqlConnection(sqlServer.getConnectionString()))
            {
                string query = $"SELECT * FROM [{tableName}]";

                if (!string.IsNullOrWhiteSpace(whereClause))
                {
                    query += whereClause;
                }

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }

            return dt;
        }
    }
}
