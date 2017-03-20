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
        public static List<Rep_001> Rep_001Get(int pMarketType, string @pDate)
        {
            SqlParameter[] parameters = new SqlParameter[2];

            DataTable myDataTable;

            if (pMarketType == 0)
            {
                parameters[0] = new SqlParameter("@pDate", @pDate);
                parameters[1] = new SqlParameter("@pMarketType", "SAM");
                myDataTable = Helper.ExecuteReader("SELECT * FROM [dbo].[Rep_001] WHERE convert(datetime, InsertedDate, 103) = @pDate AND MarketType = @pMarketType", parameters);
            }
            else
            {
                parameters[0] = new SqlParameter("@pDate", @pDate);
                parameters[1] = new SqlParameter("@pMarketType", "SEM");
                myDataTable = Helper.ExecuteReader("SELECT * FROM [dbo].[Rep_001] WHERE convert(datetime, InsertedDate, 103) = @pDate AND MarketType = @pMarketType", parameters);
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
                            TradeShare = (double)x["TradeShare"],
                            MarketType = x["MarketType"].ToString(),
                            InsertedDate = Convert.ToDateTime(x["InsertedDate"])
                        }).ToList();
            return null;
        }

        public static List<Rep_0011> Rep_0011aGet(int pMarketType, string @pDate)
        {
            SqlParameter[] parameters = new SqlParameter[2];

            DataTable myDataTable;

            if (pMarketType == 0)
            {
                parameters[0] = new SqlParameter("@pDate", @pDate);
                parameters[1] = new SqlParameter("@pMarketType", "SAM");
                myDataTable = Helper.ExecuteReader("SELECT * FROM [dbo].[Rep_0011] WHERE convert(datetime, [date], 103) = @pDate AND Market = @pMarketType AND [Type] = 'Value'", parameters);
            }
            else
            {
                parameters[0] = new SqlParameter("@pDate", @pDate);
                parameters[1] = new SqlParameter("@pMarketType", "SEM");
                myDataTable = Helper.ExecuteReader("SELECT * FROM [dbo].[Rep_0011] WHERE convert(datetime, [date], 103) = @pDate AND Market = @pMarketType AND [Type] = 'Value'", parameters);
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

        public static List<Rep_0011> Rep_0011bGet(int pMarketType, string @pDate)
        {
            SqlParameter[] parameters = new SqlParameter[2];

            DataTable myDataTable;

            if (pMarketType == 0)
            {
                parameters[0] = new SqlParameter("@pDate", @pDate);
                parameters[1] = new SqlParameter("@pMarketType", "SAM");
                myDataTable = Helper.ExecuteReader("SELECT * FROM [dbo].[Rep_0011] WHERE convert(datetime, [date], 103) = @pDate AND Market = @pMarketType AND [Type] = 'Trades'", parameters);
            }
            else
            {
                parameters[0] = new SqlParameter("@pDate", @pDate);
                parameters[1] = new SqlParameter("@pMarketType", "SEM");
                myDataTable = Helper.ExecuteReader("SELECT * FROM [dbo].[Rep_0011] WHERE convert(datetime, [date], 103) = @pDate AND Market = @pMarketType AND [Type] = 'Trades'", parameters);
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

        public static List<Rep_002> Rep_002Get(int pMarketType, string @pDate)
        {
            SqlParameter[] parameters = new SqlParameter[2];

            parameters[0] = new SqlParameter("@pDate", @pDate);

            if (pMarketType == 0)
            {
                parameters[1] = new SqlParameter("@pMarketType", "SAM");
            }
            else
            {
                parameters[1] = new SqlParameter("@pMarketType", "SEM");
            }

            DataTable myDataTable;
            myDataTable = Helper.ExecuteReader("SELECT Channel s0, SUM(Amount) AS s1, SUM(Transactions) AS s2, SUM(Percentage) AS s3, SUM(TradeShare) AS s4 FROM [dbo].[Rep_001] " +
                                                "WHERE convert(datetime, InsertedDate, 103) = @pDate AND MarketType = @pMarketType " +
                                                "GROUP BY Channel", parameters);

            if (myDataTable != null)
                return (from DataRow x in myDataTable.Rows
                        select new Rep_002
                        {
                            s0 = Helper.Channel(x["s0"].ToString()),
                            s1 = x["s1"].ToString(),
                            s2 = x["s2"].ToString(),
                            s3 = x["s3"].ToString(),
                            s4 = x["s4"].ToString(),
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