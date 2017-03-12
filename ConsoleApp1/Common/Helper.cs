using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ConsoleApp1
{
    public static class Helper
    {
        public static List<TestEnt> sqlDataReaderTest()
        {
            List<TestEnt> x = new List<TestEnt>();

            using (SqlConnection sqlConnection = GetConniction.GetRepConniction())
            {
                SqlCommand sqlCommand = new SqlCommand("SELECT * FROM [Sample].[dbo].[Products_Destination]", sqlConnection);
                sqlConnection.Open();
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        x.Add(new TestEnt()
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Name = reader["Name"].ToString(),
                            Description = reader["Description"].ToString()
                        });
                    }
                }
            }

            return x;
        }

        public static List<TestEnt> sqlDataAdapterTest()
        {
            List<TestEnt> x = new List<TestEnt>();

            using (SqlConnection sqlConnection = GetConniction.GetRepConniction())
            {
                SqlCommand sqlCommand = new SqlCommand("SELECT * FROM [Sample].[dbo].[Products_Destination]", sqlConnection);

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                foreach (DataRow rows in dataTable.Rows)
	            {
                    x.Add(new TestEnt()
                    {
                        Id = Convert.ToInt32(rows["Id"]),
                        Name = rows["Name"].ToString(),
                        Description = rows["Description"].ToString()
                    });
                }

                return x;
            }
        }
    }
}