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
                            s1 = Helper.ToGFormat(x["s1"].ToString(), 2),
                            s2 = x["s2"].ToString(),
                            s3 = x["s3"].ToString(),
                            s4 = x["s4"].ToString(),
                        }).ToList();

            return null;
        }

        public static List<Rep_0012> Rep_003Get(int @pYear, int @pMarketType)
        {
            SqlParameter[] parameters = new SqlParameter[2];

            parameters[0] = new SqlParameter("@pYear", @pYear);

            if (pMarketType == 0)
            {
                parameters[1] = new SqlParameter("@pMarketType", "SAM");
            }
            else
            {
                parameters[1] = new SqlParameter("@pMarketType", "SEM");
            }

            DataTable myDataTable;
            myDataTable = Helper.ExecuteReader("SELECT" +
                                                "S_1.[Channel], S_1.[MarketShare], S_1.[MarketTrades], S_2.[MarketShare], S_2.[MarketTrades], S_3.[MarketShare], S_3.[MarketTrades], S_4.[MarketShare], S_4.[MarketTrades]," +
                                                "S_5.[MarketShare], S_5.[MarketTrades], S_6.[MarketShare], S_6.[MarketTrades], S_7.[MarketShare], S_7.[MarketTrades], S_8.[MarketShare], S_8.[MarketTrades]," +
                                                "S_9.[MarketShare], S_9.[MarketTrades], S_10.[MarketShare], S_10.[MarketTrades], S_11.[MarketShare], S_11.[MarketTrades], S_12.[MarketShare], S_12.[MarketTrades] FROM" +
                                                "(SELECT[Channel], [MarketShare], [MarketTrades] FROM[ARC_Reports].[dbo].[Rep_0012] WHERE[Month] = 1 AND[MarketType] = @pMarketType AND[Year] = @pYear) S_1" +
                                                "LEFT OUTER JOIN" +
                                                "(SELECT[Channel], [MarketShare], [MarketTrades] FROM[ARC_Reports].[dbo].[Rep_0012] WHERE[Month] = 2 AND[MarketType] = @pMarketType AND[Year] = @pYear) S_2" +
                                                "ON S_1.[Channel] = S_2.[Channel]" +
                                                "LEFT OUTER JOIN" +
                                                "(SELECT[Channel], [MarketShare], [MarketTrades] FROM[ARC_Reports].[dbo].[Rep_0012] WHERE[Month] = 3 AND[MarketType] = @pMarketType AND[Year] = @pYear) S_3" +
                                                "ON S_1.[Channel] = S_3.[Channel]" +
                                                "LEFT OUTER JOIN" +
                                                "(SELECT[Channel], [MarketShare], [MarketTrades] FROM[ARC_Reports].[dbo].[Rep_0012] WHERE[Month] = 4 AND[MarketType] = @pMarketType AND[Year] = @pYear) S_4" +
                                                "ON S_1.[Channel] = S_4.[Channel]" +
                                                "LEFT OUTER JOIN" +
                                                "(SELECT[Channel], [MarketShare], [MarketTrades] FROM[ARC_Reports].[dbo].[Rep_0012] WHERE[Month] = 4 AND[MarketType] = @pMarketType AND[Year] = @pYear) S_5" +
                                                "ON S_1.[Channel] = S_5.[Channel]" +
                                                "LEFT OUTER JOIN" +
                                                "(SELECT[Channel], [MarketShare], [MarketTrades] FROM[ARC_Reports].[dbo].[Rep_0012] WHERE[Month] = 4 AND[MarketType] = @pMarketType AND[Year] = @pYear) S_6" +
                                                "ON S_1.[Channel] = S_6.[Channel]" +
                                                "LEFT OUTER JOIN" +
                                                "(SELECT[Channel], [MarketShare], [MarketTrades] FROM[ARC_Reports].[dbo].[Rep_0012] WHERE[Month] = 4 AND[MarketType] = @pMarketType AND[Year] = @pYear) S_7" +
                                                "ON S_1.[Channel] = S_7.[Channel]" +
                                                "LEFT OUTER JOIN" +
                                                "(SELECT[Channel], [MarketShare], [MarketTrades] FROM[ARC_Reports].[dbo].[Rep_0012] WHERE[Month] = 4 AND[MarketType] = @pMarketType AND[Year] = @pYear) S_8" +
                                                "ON S_1.[Channel] = S_8.[Channel]" +
                                                "LEFT OUTER JOIN" +
                                                "(SELECT[Channel], [MarketShare], [MarketTrades] FROM[ARC_Reports].[dbo].[Rep_0012] WHERE[Month] = 4 AND[MarketType] = @pMarketType AND[Year] = @pYear) S_9" +
                                                "ON S_1.[Channel] = S_9.[Channel]" +
                                                "LEFT OUTER JOIN" +
                                                "(SELECT[Channel], [MarketShare], [MarketTrades] FROM[ARC_Reports].[dbo].[Rep_0012] WHERE[Month] = 4 AND[MarketType] = @pMarketType AND[Year] = @pYear) S_10" +
                                                "ON S_1.[Channel] = S_10.[Channel]" +
                                                "LEFT OUTER JOIN" +
                                                "(SELECT[Channel], [MarketShare], [MarketTrades] FROM[ARC_Reports].[dbo].[Rep_0012] WHERE[Month] = 4 AND[MarketType] = @pMarketType AND[Year] = @pYear) S_11" +
                                                "ON S_1.[Channel] = S_11.[Channel]" +
                                                "LEFT OUTER JOIN" +
                                                "(SELECT[Channel], [MarketShare], [MarketTrades] FROM[ARC_Reports].[dbo].[Rep_0012] WHERE[Month] = 4 AND[MarketType] = @pMarketType AND[Year] = @pYear) S_12" +
                                                "ON S_1.[Channel] = S_12.[Channel]", parameters);

            if (myDataTable != null)
                return (from DataRow x in myDataTable.Rows
                        select new Rep_0012
                        {
                            Channel = Helper.Channel(x[0].ToString()),
                            MarketShare_1 = (double)x[1],
                            MarketTrades_1 = (double)x[2],
                            MarketShare_2 = (double)x[3],
                            MarketTrades_2 = (double)x[4],
                            MarketShare_3 = (double)x[5],
                            MarketTrades_3 = (double)x[6],
                            MarketShare_4 = (double)x[7],
                            MarketTrades_4 = (double)x[8],
                            MarketShare_5 = (double)x[9],
                            MarketTrades_5 = (double)x[10],
                            MarketShare_6 = (double)x[11],
                            MarketTrades_6 = (double)x[12],
                            MarketShare_7 = (double)x[13],
                            MarketTrades_7 = (double)x[14],
                            MarketShare_8 = (double)x[15],
                            MarketTrades_8 = (double)x[16],
                            MarketShare_9 = (double)x[17],
                            MarketTrades_9 = (double)x[18],
                            MarketShare_10 = (double)x[19],
                            MarketTrades_10 = (double)x[20],
                            MarketShare_11 = (double)x[21],
                            MarketTrades_11 = (double)x[22],
                            MarketShare_12 = (double)x[23],
                            MarketTrades_12 = (double)x[24],

                        }).ToList();
            return null;
        }

        public static List<Rep_002> Rep_004Get(int pMarketType, string @pDate)
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
                            s1 = Helper.ToGFormat(x["s1"].ToString(), 2),
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