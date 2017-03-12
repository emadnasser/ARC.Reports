using ARC.Reports.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;

namespace ARC.Reports.DAL.Common
{
    public static class Helper
    {
        public static DataTable ExecuteReader(string cmdText, SqlParameter[] sqlParameters = null)
        {
            using (SqlConnection sqlConnection = GetConniction.GetRepConniction())
            {
                SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
                //sqlCommand.Parameters.AddWithValue("@ProductName", productName + "%");

                if (sqlParameters != null)
                    sqlCommand.Parameters.AddRange(sqlParameters.ToArray());

                sqlConnection.Open();
                var sqlDataReader = sqlCommand.ExecuteReader();

                var x = new DataTable();
                x.Load(sqlDataReader);

                sqlCommand.Dispose();
                sqlConnection.Close();

                return x;
            }
        }

        public static DataTable ExecStoredProcedure(string procedureName, SqlParameter[] parameters = null)
        {
            using (var sqlConnectionObj = GetConniction.GetRepConniction())
            {
                var sqlCommandObj = new SqlCommand(procedureName, sqlConnectionObj)
                {
                    CommandType = CommandType.StoredProcedure,
                };

                if (parameters != null)
                    sqlCommandObj.Parameters.AddRange(parameters.ToArray());

                sqlConnectionObj.Open();
                sqlCommandObj.Connection = sqlConnectionObj;

                var sqlDataReaderObj = sqlCommandObj.ExecuteReader();

                //while (sqlDataReaderObj.Read())
                //{
                //    object.x = Convert.ToInt32(sqlDataReaderObj["idFormDB"]);
                //    ...
                //    ...
                //}

                var x = new DataTable();
                x.Load(sqlDataReaderObj);

                sqlCommandObj.Dispose();
                sqlConnectionObj.Close();

                return x;
            }
        }

        public static object ExecuteScalar(string procedureName)
        {
            using (var sqlConnectionObj = GetConniction.GetRepConniction())
            {
                var sqlCommandObj = new SqlCommand(procedureName, sqlConnectionObj)
                {
                    CommandType = CommandType.StoredProcedure
                };

                if (sqlConnectionObj.State != ConnectionState.Open)
                    sqlConnectionObj.Open();

                var x = sqlCommandObj.ExecuteScalar();

                sqlCommandObj.Dispose();
                sqlConnectionObj.Close();

                return x;
            }
        }

        public static object ExecuteNonQuery(string procedureName, SqlParameter[] parameters = null)
        {
            using (var sqlConnectionObj = GetConniction.GetRepConniction())
            {
                var sqlCommandObj = new SqlCommand(procedureName, sqlConnectionObj)
                {
                    CommandType = CommandType.StoredProcedure
                };

                if (parameters != null)
                    sqlCommandObj.Parameters.AddRange(parameters);

                if (sqlConnectionObj.State != ConnectionState.Open)
                    sqlConnectionObj.Open();

                var x = sqlCommandObj.ExecuteNonQuery();

                sqlCommandObj.Dispose();
                sqlConnectionObj.Close();

                return x;
            }
        }

        public static string ToGFormat(string value, int fraction)
        {
            double x;

            if (double.TryParse(value, out x))
            {
                switch (fraction)
                {
                    case 0:
                        var xy = Convert.ToInt32(value);
                        return xy.ToString("N0", CultureInfo.InvariantCulture);
                    case 1:
                        return x.ToString("N1", CultureInfo.InvariantCulture);
                    case 2:
                        return x.ToString("N2", CultureInfo.InvariantCulture);
                    case 3:
                        return x.ToString("N3", CultureInfo.InvariantCulture);
                    default:
                        return "0.00";
                }
            }
            return "0.00";
        }

        public static string Channel(string x)
        {
            switch (x)
            {
                case "A":
                    return "APT";
                case "B":
                    return "Branches";
                case "C":
                    return "CTF";
                case "F":
                    return "Internet";
                case "I":
                    return "IPO";
                case "O":
                    return "ORM";
                case "P":
                    return "Mobile";
                case "T":
                    return "ETS";
                case "M":
                    return "AMS";
                case "S":
                    return "SMS";
                default:
                    return x;
            }
        }

        public static string Operation(string x)
        {
            switch (x)
            {
                case "A":
                    return "Buy";
                case "V":
                    return "Sell";
                default:
                    return x;
            }
        }

        /// /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
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