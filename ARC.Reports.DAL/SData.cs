using System.Collections.Generic;
using ARC.Reports.DAL.Common;
using System.Data;
using System.Linq;
using System.Data.SqlClient;
using System;
using ARC.Reports.DAL.Entities;

namespace ARC.Reports.DAL
{
    public static class SData
    {
        public static List<Rep_001> Rep_001Get(int pMarketType)
        {
            SqlParameter[] parameters = new SqlParameter[1];

            DataTable myDataTable;

            if (pMarketType == 0)
            {
                parameters[0] = new SqlParameter("@pMarketType", "SAM");
                myDataTable = Helper.ExecuteReader("SELECT * FROM [dbo].[Rep_001] WHERE CONVERT(DATE, GETDATE()-3) = InsertedDate AND MarketType = @pMarketType", parameters);
            }
            else
            {
                parameters[0] = new SqlParameter("@pMarketType", "SEM");
                myDataTable = Helper.ExecuteReader("SELECT * FROM [dbo].[Rep_001] WHERE CONVERT(DATE, GETDATE()-3) = InsertedDate AND MarketType = @pMarketType", parameters);
            }

            if (myDataTable != null)
                return (from DataRow x in myDataTable.Rows
                        select new Rep_001
                        {
                            Id = (int)x["Id"],
                            Channel = Helper.Channel(x["Channel"].ToString()),
                            Operation = Helper.Operation(x["Operation"].ToString()),
                            Amount = Helper.ToGFormat(x["Amount"].ToString(), 2),
                            Transactions = (int)x["Transactions"],
                            Percentage = (double)x["Percentage"],
                            MarketType = x["MarketType"].ToString(),
                            InsertedDate = System.Convert.ToDateTime(x["InsertedDate"])
                        }).ToList();
            return null;
        }

        public static List<Rep_0011> Rep_0011Get(int pMarketType)
        {
            SqlParameter[] parameters = new SqlParameter[1];

            DataTable myDataTable;

            if (pMarketType == 0)
            {
                parameters[0] = new SqlParameter("@pMarketType", "SAM");
                myDataTable = Helper.ExecuteReader("SELECT * FROM [dbo].[Rep_0011] WHERE CONVERT(DATE, GETDATE()-3) = date AND Market = @pMarketType", parameters);
            }
            else
            {
                parameters[0] = new SqlParameter("@pMarketType", "SEM");
                myDataTable = Helper.ExecuteReader("SELECT * FROM [dbo].[Rep_0011] WHERE CONVERT(DATE, GETDATE()-3) = date AND Market = @pMarketType", parameters);
            }

            if (myDataTable != null)
                return (from DataRow x in myDataTable.Rows
                        select new Rep_0011
                        {
                            Id = (int)x["Id"],
                            Buy_Total_Ammount = Helper.ToGFormat(x["Buy_Total_Ammount"].ToString(), 2),
                            Sell_Total_Ammount = Helper.ToGFormat(x["Sell_Total_Ammount"].ToString(), 2),
                            ETS_Share_Value = Helper.ToGFormat(x["ETS_Share_Value"].ToString(), 2),
                            Market_Share_Value = Helper.ToGFormat(x["Market_Share_Value"].ToString(), 2),
                            Percentage = Helper.ToGFormat(x["Percentage"].ToString(), 2),
                            Market = x["Market"].ToString(),
                            date = Convert.ToDateTime(x["date"])
                        }).ToList();
            return null;
        }

        public static List<TestEnt> Test_01()
        {
            return Helper.sqlDataReaderTest();
        }

        public static List<TestEnt> Test_02()
        {
            return Helper.sqlDataAdapterTest();
        }
    }
}