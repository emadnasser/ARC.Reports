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
                            Market_Share_Index = Helper.ToGFormat(x["Market_Share_Index"].ToString(), 2),
                            DiffDayNom = x["DiffDayPer"].ToString() + "% // " + x["DiffDayNom"].ToString(),
                            DiffDayPer = x["DiffDayPer"].ToString(),
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
                            Market_Share_Index = Helper.ToGFormat(x["Market_Share_Index"].ToString(), 2),
                            DiffDayNom = x["DiffDayPer"].ToString() + "% // " + x["DiffDayNom"].ToString(),
                            DiffDayPer = x["DiffDayPer"].ToString(),
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
            SqlParameter[] parameters = new SqlParameter[3];

            parameters[0] = new SqlParameter("@pYear", @pYear);

            if (pMarketType == 0)
            {
                parameters[1] = new SqlParameter("@pMarketType", "SAM");
            }
            else
            {
                parameters[1] = new SqlParameter("@pMarketType", "SEM");
            }

            parameters[2] = new SqlParameter("@pNumberOfDays", Rep_006Get());

            DataTable myDataTable;
            myDataTable = Helper.ExecuteReader("SELECT" +
                                                " S_1.[Channel], S_1.[MarketShare], S_1.[MarketTrades], S_2.[MarketShare], S_2.[MarketTrades], S_3.[MarketShare], S_3.[MarketTrades], S_4.[MarketShare], S_4.[MarketTrades]," +
                                                " S_5.[MarketShare], S_5.[MarketTrades], S_6.[MarketShare], S_6.[MarketTrades], S_7.[MarketShare], S_7.[MarketTrades], S_8.[MarketShare], S_8.[MarketTrades]," +
                                                " S_9.[MarketShare], S_9.[MarketTrades], S_10.[MarketShare], S_10.[MarketTrades], S_11.[MarketShare], S_11.[MarketTrades], " +
                                                " S_12.[MarketShare], S_12.[MarketTrades], S_13.[MarketShare], S_13.[MarketTrades] FROM" +
                                                " (SELECT[Channel], [MarketShare], [MarketTrades] FROM[ARC_Reports].[dbo].[Rep_0012] WHERE [Month] = 1 AND [MarketType] = @pMarketType AND [Year] = @pYear) S_1 " +
                                                " LEFT OUTER JOIN" +
                                                " (SELECT[Channel], [MarketShare], [MarketTrades] FROM[ARC_Reports].[dbo].[Rep_0012] WHERE [Month] = 2 AND [MarketType] = @pMarketType AND [Year] = @pYear) S_2 " +
                                                " ON S_1.[Channel] = S_2.[Channel]" +
                                                " LEFT OUTER JOIN" +
                                                " (SELECT[Channel], [MarketShare], [MarketTrades] FROM[ARC_Reports].[dbo].[Rep_0012] WHERE [Month] = 3 AND [MarketType] = @pMarketType AND [Year] = @pYear) S_3 " +
                                                " ON S_1.[Channel] = S_3.[Channel]" +
                                                " LEFT OUTER JOIN" +
                                                " (SELECT[Channel], [MarketShare], [MarketTrades] FROM[ARC_Reports].[dbo].[Rep_0012] WHERE [Month] = 4 AND [MarketType] = @pMarketType AND [Year] = @pYear) S_4 " +
                                                " ON S_1.[Channel] = S_4.[Channel]" +
                                                " LEFT OUTER JOIN" +
                                                " (SELECT[Channel], [MarketShare], [MarketTrades] FROM[ARC_Reports].[dbo].[Rep_0012] WHERE [Month] = 5 AND [MarketType] = @pMarketType AND [Year] = @pYear) S_5 " +
                                                " ON S_1.[Channel] = S_5.[Channel]" +
                                                " LEFT OUTER JOIN" +
                                                " (SELECT[Channel], [MarketShare], [MarketTrades] FROM[ARC_Reports].[dbo].[Rep_0012] WHERE [Month] = 6 AND [MarketType] = @pMarketType AND [Year] = @pYear) S_6 " +
                                                " ON S_1.[Channel] = S_6.[Channel]" +
                                                " LEFT OUTER JOIN" +
                                                " (SELECT[Channel], [MarketShare], [MarketTrades] FROM[ARC_Reports].[dbo].[Rep_0012] WHERE [Month] = 7 AND [MarketType] = @pMarketType AND [Year] = @pYear) S_7 " +
                                                " ON S_1.[Channel] = S_7.[Channel]" +
                                                " LEFT OUTER JOIN" +
                                                " (SELECT[Channel], [MarketShare], [MarketTrades] FROM[ARC_Reports].[dbo].[Rep_0012] WHERE [Month] = 8 AND [MarketType] = @pMarketType AND [Year] = @pYear) S_8 " +
                                                " ON S_1.[Channel] = S_8.[Channel]" +
                                                " LEFT OUTER JOIN" +
                                                " (SELECT[Channel], [MarketShare], [MarketTrades] FROM[ARC_Reports].[dbo].[Rep_0012] WHERE [Month] = 9 AND [MarketType] = @pMarketType AND [Year] = @pYear) S_9 " +
                                                " ON S_1.[Channel] = S_9.[Channel]" +
                                                " LEFT OUTER JOIN" +
                                                " (SELECT[Channel], [MarketShare], [MarketTrades] FROM[ARC_Reports].[dbo].[Rep_0012] WHERE [Month] = 10 AND [MarketType] = @pMarketType AND [Year] = @pYear) S_10 " +
                                                " ON S_1.[Channel] = S_10.[Channel]" +
                                                " LEFT OUTER JOIN" +
                                                " (SELECT[Channel], [MarketShare], [MarketTrades] FROM[ARC_Reports].[dbo].[Rep_0012] WHERE [Month] = 11 AND [MarketType] = @pMarketType AND [Year] = @pYear) S_11 " +
                                                " ON S_1.[Channel] = S_11.[Channel]" +
                                                " LEFT OUTER JOIN" +
                                                " (SELECT[Channel], [MarketShare], [MarketTrades] FROM[ARC_Reports].[dbo].[Rep_0012] WHERE [Month] = 12 AND [MarketType] = @pMarketType AND [Year] = @pYear) S_12 " +
                                                " ON S_1.[Channel] = S_12.[Channel]" +
                                                " LEFT OUTER JOIN" +
                                                " (SELECT[Channel], ROUND(SUM(Percentage)/ @pNumberOfDays, 2) AS[MarketShare], ROUND(SUM(TradeShare)/ @pNumberOfDays, 2) AS[MarketTrades]" +
                                                " FROM[dbo].[Rep_001]" +
                                                " WHERE MONTH(InsertedDate) = MONTH(GETDATE()) AND MarketType = @pMarketType AND YEAR(InsertedDate) = @pYear" +
                                                " GROUP BY Channel) S_13" +
                                                " ON S_1.[Channel] = S_13.[Channel]" +
                                                " WHERE S_1.[Channel] != 'AVG'" +
                                                " ORDER BY S_1.[Channel]", parameters);

            if (myDataTable != null)
                return (from DataRow x in myDataTable.Rows
                        select new Rep_0012
                        {
                            Channel = Helper.Channel(x[0].ToString()),
                            MarketShare_1 = x[1] != DBNull.Value ? (double?)x[1] : 0,
                            MarketTrades_1 = x[2] != DBNull.Value ? (double?)x[2] : 0,
                            MarketShare_2 = x[3] != DBNull.Value ? (double?)x[3] : 0,
                            MarketTrades_2 = x[4] != DBNull.Value ? (double?)x[4] : 0,
                            MarketShare_3 = x[5] != DBNull.Value ? (double?)x[5] : 0,
                            MarketTrades_3 = x[6] != DBNull.Value ? (double?)x[6] : 0,
                            MarketShare_4 = x[7] != DBNull.Value ? (double?)x[7] : 0,
                            MarketTrades_4 = x[8] != DBNull.Value ? (double?)x[8] : 0,
                            MarketShare_5 = x[9] != DBNull.Value ? (double?)x[9] : 0,
                            MarketTrades_5 = x[10] != DBNull.Value ? (double?)x[10] : 0,
                            MarketShare_6 = x[11] != DBNull.Value ? (double?)x[11] : 0,
                            MarketTrades_6 = x[12] != DBNull.Value ? (double?)x[12] : 0,
                            MarketShare_7 = x[13] != DBNull.Value ? (double?)x[13] : 0,
                            MarketTrades_7 = x[14] != DBNull.Value ? (double?)x[14] : 0,
                            MarketShare_8 = x[15] != DBNull.Value ? (double?)x[15] : 0,
                            MarketTrades_8 = x[16] != DBNull.Value ? (double?)x[16] : 0,
                            MarketShare_9 = x[17] != DBNull.Value ? (double?)x[17] : 0,
                            MarketTrades_9 = x[18] != DBNull.Value ? (double?)x[18] : 0,
                            MarketShare_10 = x[19] != DBNull.Value ? (double?)x[19] : 0,
                            MarketTrades_10 = x[20] != DBNull.Value ? (double?)x[20] : 0,
                            MarketShare_11 = x[21] != DBNull.Value ? (double?)x[21] : 0,
                            MarketTrades_11 = x[22] != DBNull.Value ? (double?)x[22] : 0,
                            MarketShare_12 = x[23] != DBNull.Value ? (double?)x[23] : 0,
                            MarketTrades_12 = x[24] != DBNull.Value ? (double?)x[24] : 0,
                            MarketShare_13 = x[25] != DBNull.Value ? (double?)x[25] : 0,
                            MarketTrades_13 = x[26] != DBNull.Value ? (double?)x[26] : 0,

                        }).ToList();
            return null;
        }

        public static List<Rep_0013> Rep_004Get(int @pMarketType)
        {
            SqlParameter[] parameters = new SqlParameter[4];

            parameters[0] = new SqlParameter("@pYear_0", DateTime.Now.Year - 3);
            parameters[1] = new SqlParameter("@pYear_1", DateTime.Now.Year - 2);
            parameters[2] = new SqlParameter("@pYear_2", DateTime.Now.Year - 1);

            if (pMarketType == 0)
            {
                parameters[3] = new SqlParameter("@pMarketType", "SAM");
            }
            else
            {
                parameters[3] = new SqlParameter("@pMarketType", "SEM");
            }

            DataTable myDataTable;
            myDataTable = Helper.ExecuteReader("SELECT" +
                                                " S_1.[Channel], S_1.[MarketShare], S_1.[MarketTrades], S_2.[MarketShare], S_2.[MarketTrades], S_3.[MarketShare], S_3.[MarketTrades] FROM" +
                                                " (SELECT[Channel], [MarketShare], [MarketTrades] FROM[ARC_Reports].[dbo].[Rep_0013] WHERE[MarketType] = @pMarketType AND[Year] = @pYear_0) S_1" +
                                                " LEFT OUTER JOIN" +
                                                " (SELECT[Channel], [MarketShare], [MarketTrades] FROM[ARC_Reports].[dbo].[Rep_0013] WHERE[MarketType] = @pMarketType AND[Year] = @pYear_1) S_2" +
                                                " ON S_1.[Channel] = S_2.[Channel]" +
                                                " LEFT OUTER JOIN" +
                                                " (SELECT[Channel], [MarketShare], [MarketTrades] FROM[ARC_Reports].[dbo].[Rep_0013] WHERE[MarketType] = @pMarketType AND[Year] = @pYear_2) S_3" +
                                                " ON S_1.[Channel] = S_3.[Channel] ORDER BY S_1.[Channel]", parameters);

            if (myDataTable != null)
                return (from DataRow x in myDataTable.Rows
                        select new Rep_0013
                        {
                            Channel = Helper.Channel(x[0].ToString()),
                            MarketShare_1 = x[1] != DBNull.Value ? (double?)x[1] : 0,
                            MarketTrades_1 = x[2] != DBNull.Value ? (double?)x[2] : 0,
                            MarketShare_2 = x[3] != DBNull.Value ? (double?)x[3] : 0,
                            MarketTrades_2 = x[4] != DBNull.Value ? (double?)x[4] : 0,
                            MarketShare_3 = x[5] != DBNull.Value ? (double?)x[5] : 0,
                            MarketTrades_3 = x[6] != DBNull.Value ? (double?)x[6] : 0
                        }).ToList();
            return null;
        }

        public static List<Rep_0012> Rep_005Get(int @pYear, int @pMarketType)
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
                                                 " S_1.[Channel], S_1.[MarketShare], S_1.[MarketTrades], S_2.[MarketShare], S_2.[MarketTrades], S_3.[MarketShare], S_3.[MarketTrades], S_4.[MarketShare], S_4.[MarketTrades] FROM" +
                                                 " (SELECT[Channel], SUM([MarketShare])/3 AS[MarketShare], SUM([MarketTrades])/3 AS[MarketTrades] FROM[ARC_Reports].[dbo].[Rep_0012] WHERE[Month] IN(1, 2, 3) AND[MarketType] = @pMarketType AND[Year] = @pYear GROUP BY[Channel] HAVING MAX(Month) = 3) S_1" +
                                                 " LEFT OUTER JOIN" +
                                                 " (SELECT[Channel], SUM([MarketShare])/3 AS [MarketShare], SUM([MarketTrades])/3 AS [MarketTrades] FROM[ARC_Reports].[dbo].[Rep_0012] WHERE[Month] IN (4, 5, 6) AND[MarketType] = @pMarketType AND[Year] = @pYear GROUP BY[Channel] HAVING MAX(Month) = 6) S_2" +
                                                 " ON S_1.[Channel] = S_2.[Channel]" +
                                                 " LEFT OUTER JOIN" +
                                                 " (SELECT[Channel], SUM([MarketShare])/3 AS[MarketShare], SUM([MarketTrades])/3 AS[MarketTrades] FROM[ARC_Reports].[dbo].[Rep_0012] WHERE[Month] IN(7, 8, 9) AND[MarketType] = @pMarketType AND[Year] = @pYear GROUP BY[Channel] HAVING MAX(Month) = 9) S_3" +
                                                 " ON S_1.[Channel] = S_3.[Channel]" +
                                                 " LEFT OUTER JOIN" +
                                                 " (SELECT[Channel], SUM([MarketShare])/3 AS[MarketShare], SUM([MarketTrades])/3 AS[MarketTrades] FROM[ARC_Reports].[dbo].[Rep_0012] WHERE[Month] IN(10, 11, 12) AND[MarketType] = @pMarketType AND[Year] = @pYear GROUP BY[Channel] HAVING MAX(Month) = 12) S_4" +
                                                 " ON S_1.[Channel] = S_4.[Channel]" +
                                                 " ORDER BY S_1.[Channel]", parameters);

            if (myDataTable != null)
                return (from DataRow x in myDataTable.Rows
                        select new Rep_0012
                        {
                            Channel = Helper.Channel(x[0].ToString()),
                            MarketShare_1 = x[1] != DBNull.Value ? Convert.ToDouble(Helper.ToGFormat(x[1].ToString(), 2)) : 0,
                            MarketTrades_1 = x[2] != DBNull.Value ? Convert.ToDouble(Helper.ToGFormat(x[2].ToString(), 2)) : 0,
                            MarketShare_2 = x[3] != DBNull.Value ? Convert.ToDouble(Helper.ToGFormat(x[3].ToString(), 2)) : 0,
                            MarketTrades_2 = x[4] != DBNull.Value ? Convert.ToDouble(Helper.ToGFormat(x[4].ToString(), 2)) : 0,
                            MarketShare_3 = x[5] != DBNull.Value ? Convert.ToDouble(Helper.ToGFormat(x[5].ToString(), 2)) : 0,
                            MarketTrades_3 = x[6] != DBNull.Value ? Convert.ToDouble(Helper.ToGFormat(x[6].ToString(), 2)) : 0,
                            MarketShare_4 = x[7] != DBNull.Value ? Convert.ToDouble(Helper.ToGFormat(x[7].ToString(), 2)) : 0,
                            MarketTrades_4 = x[8] != DBNull.Value ? Convert.ToDouble(Helper.ToGFormat(x[8].ToString(), 2)) : 0,

                        }).ToList();
            return null;
        }

        public static int Rep_006Get()
        {
            var RetVal = Convert.ToInt32(Helper.ExecuteScalar(" SELECT COUNT(DISTINCT InsertedDate) FROM [dbo].[Rep_001]" +
                                                              " WHERE MONTH(InsertedDate) = MONTH(GETDATE()) AND MarketType = 'SAM' AND YEAR(InsertedDate) = '2017'"));

            if (RetVal != 0)
                return RetVal;
            return 1;
        }

        public static List<Rep_007> Rep_007Get(int @pYear, int @pMarketType)
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
            myDataTable = Helper.ExecuteReader(
                " SELECT MarketShare, MarketTrades, [Month] FROM[Rep_0012]" +
                " WHERE[Channel] = 'AVG' AND[MarketType] = @pMarketType AND[Year] = @pYear" +
                " ORDER BY[Month]", parameters);

            if (myDataTable != null)
                return (from DataRow x in myDataTable.Rows
                        select new Rep_007
                        {
                            MarketShare = x[0].ToString(),
                            MarketTrades = x[1].ToString(),
                            Month = x[2].ToString(),

                        }).ToList();
            return null;
        }

        public static Rep_007 Rep_008Get(int pMarketType, string @pDate)
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
            myDataTable = Helper.ExecuteReader(" SELECT ROUND(SUM(Percentage)/ 9, 2) AS[MarketShare], ROUND(SUM(TradeShare) / 9, 2) AS[MarketTrades]" +
                                               " FROM[dbo].[Rep_001]" +
                                               " WHERE MONTH(InsertedDate) = MONTH(GETDATE()) AND MarketType = @pMarketType AND YEAR(InsertedDate) = @pDate", parameters);

            if (myDataTable != null)
                return new Rep_007()
                {
                    MarketShare = myDataTable.Rows[0][0].ToString(),
                    MarketTrades = myDataTable.Rows[0][1].ToString(),
                };

            return null;
        }

        public static List<Rep_001> Rep_emad(int pMarketType)
        {
            SqlParameter[] parameters = new SqlParameter[1];

            DataTable myDataTable;

            if (pMarketType == 0)
            {
                parameters[0] = new SqlParameter("@pMarketType", "SAM");
                myDataTable = Helper.ExecuteReader("SELECT * FROM [dbo].[Rep_001] WHERE MarketType = @pMarketType", parameters);
            }
            else
            {
                parameters[0] = new SqlParameter("@pMarketType", "SEM");
                myDataTable = Helper.ExecuteReader("SELECT * FROM [dbo].[Rep_001] WHERE MarketType = @pMarketType", parameters);
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