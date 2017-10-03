using System.Collections.Generic;
using ARC.Reports.DAL.Common;
using System.Data;
using System.Linq;
using System.Data.SqlClient;
using System;
using ARC.Reports.DAL.Entities;
using System.Globalization;

namespace ARC.Reports.DAL
{
    public static class SData
    {
        public static List<MarketShareTotal_D_Totals> MarketShareTotal_D_Totals(int pMarketType, int pType, string @pDate)
        {
            SqlParameter[] parameters = new SqlParameter[3];

            DataTable myDataTable;

            parameters[0] = new SqlParameter("@pDate", @pDate);

            if (pMarketType == 0)
            {
                parameters[1] = new SqlParameter("@pMarketType", "SAM");
            }
            else
            {
                parameters[1] = new SqlParameter("@pMarketType", "SEM");
            }

            if (pType == 0)
            {
                parameters[2] = new SqlParameter("@pType", "Value");
            }
            else
            {
                parameters[2] = new SqlParameter("@pType", "Trades");
            }

            myDataTable = Helper.ExecuteReader("SELECT * FROM [dbo].[Rep_0011] WHERE convert(datetime, [date], 103) = @pDate AND Market = @pMarketType AND [Type] = @pType", parameters);

            if (myDataTable != null)
                return (from DataRow x in myDataTable.Rows
                        select new MarketShareTotal_D_Totals
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

        public static List<MarketShareTotal_D> MarketShareTotal_D(int pMarketType, string @pDate)
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
                        select new MarketShareTotal_D
                        {
                            s0 = Helper.Channel(x["s0"].ToString()),
                            s1 = Helper.ToGFormat(x["s1"].ToString(), 2),
                            s2 = x["s2"].ToString(),
                            s3 = x["s3"].ToString(),
                            s4 = x["s4"].ToString(),
                        }).ToList();

            return null;
        }

        public static List<MarketShareDetail> MarketShareDetail(int pMarketType, string @pDate)
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
                        select new MarketShareDetail
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

        public static List<MarketShareTotal_M> MarketShareTotal_M(int @pYear, int @pMarketType)
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

            parameters[2] = new SqlParameter("@pNumberOfDays", MarketShareAvgDevetion());

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
                                                " (SELECT[Channel], [MarketShare], [MarketTrades]" +
                                                " FROM[dbo].[Rep_0012]" +
                                                " WHERE MONTH(InsertedDate) = MONTH(GETDATE()) AND MarketType = @pMarketType AND YEAR(InsertedDate) = @pYear" +
                                                " ) S_13" +
                                                " ON S_1.[Channel] = S_13.[Channel]" +
                                                " WHERE S_1.[Channel] != 'AVG'" +
                                                " ORDER BY S_1.[Channel]", parameters);

            if (myDataTable != null)
                return (from DataRow x in myDataTable.Rows
                        select new MarketShareTotal_M
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

        public static List<MarketShareTotal_Q> MarketShareTotal_Q(int @pYear, int @pMarketType)
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
                        select new MarketShareTotal_Q
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

        public static List<MarketShareTotal_Y> MarketShareTotal_Y(int @pMarketType)
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
                        select new MarketShareTotal_Y
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

        public static List<MarketShareAVG> MarketShareAVG(int @pYear, int @pMarketType)
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
                        select new MarketShareAVG
                        {
                            MarketShare = x[0].ToString(),
                            MarketTrades = x[1].ToString(),
                            Month = x[2].ToString(),
                        }).ToList();
            return null;
        }

        public static int MarketShareAvgDevetion()
        {
            var RetVal = Convert.ToInt32(Helper.ExecuteScalar(" SELECT COUNT(DISTINCT InsertedDate) FROM [dbo].[Rep_001]" +
                                                              " WHERE MONTH(InsertedDate) = MONTH(GETDATE()) AND MarketType = 'SAM' AND YEAR(InsertedDate) = '2017'"));

            if (RetVal != 0)
                return RetVal;
            return 1;
        }

        public static List<BrokerageMetricsYearly> BrokerageMetricsYearly()
        {
            DataTable myDataTable;
            myDataTable = Helper.ExecuteReader(" SELECT [Period], [Active_CICs], [Trunover], [Port_Value] FROM [ARC_Reports].[dbo].[Brokerage_Metrics_Yearly] ORDER BY [Id] DESC");

            if (myDataTable != null)
                return (from DataRow x in myDataTable.Rows
                        select new BrokerageMetricsYearly
                        {
                            Period_0 = BrokerageMetricsYearlyPeriod(x[0].ToString()),
                            Period_1 = "(" + x[0].ToString() + ")",
                            Active_CICs = Helper.ToGFormat(x[1].ToString(), 0),
                            Trunover = Helper.ToGFormat(x[2].ToString(), 2),
                            Port_Value = Helper.ToGFormat(x[3].ToString(), 2),
                        }).ToList();
            return null;
        }

        public static List<BrokerageMetricsMonthly> BrokerageMetricsMonthly()
        {
            DataTable myDataTable;
            myDataTable = Helper.ExecuteReader(" SELECT [Month], [Active_CICs], [Turnover], [Port_Value] FROM [ARC_Reports].[dbo].[Brokerage_Metrics_Monthly] ORDER BY [Id] DESC");

            if (myDataTable != null)
                return (from DataRow x in myDataTable.Rows
                        select new BrokerageMetricsMonthly
                        {
                            Months = x[0].ToString(),
                            Active_CICs = Helper.ToGFormat(x[1].ToString(), 0),
                            Turnover = Helper.ToGFormat(x[2].ToString(), 2),
                            Port_Value = Helper.ToGFormat(x[3].ToString(), 2),
                        }).ToList();
            return null;
        }

        public static string BrokerageMetricsYearlyPeriod(string str)
        {
            var x = str.Split('-');

            string ret = string.Empty;
            DateTime dateTime_0 = new DateTime(Convert.ToInt32(x[0].Split('/')[2].Trim()), Convert.ToInt32(x[0].Split('/')[1].Trim()), Convert.ToInt32(x[0].Split('/')[0].Trim()));
            DateTime dateTime_1 = new DateTime(Convert.ToInt32(x[1].Split('/')[2].Trim()), Convert.ToInt32(x[1].Split('/')[1].Trim()), Convert.ToInt32(x[1].Split('/')[0].Trim()));

            ret = dateTime_0.ToString("MMM", CultureInfo.InvariantCulture) + " " + dateTime_0.Year;
            ret += " - ";
            ret += dateTime_1.ToString("MMM", CultureInfo.InvariantCulture) + " " + dateTime_1.Year;

            return ret;
        }

        public static MarketShareAVG Rep_008Get(int pMarketType, string @pDate)
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
                return new MarketShareAVG()
                {
                    MarketShare = myDataTable.Rows[0][0].ToString(),
                    MarketTrades = myDataTable.Rows[0][1].ToString(),
                };

            return null;
        }

        public static List<CommissionSummary> CommissionSummary()
        {
            DataTable myDataTable = new DataTable();

            myDataTable = Helper.ExecuteReader("SELECT" +
                                                  " CIC, EQUATOR, AGENT, SYMBOL," +
                                                  " SUBSTRING([DATE_], 1, 2) AS[Month]," +
                                                  " SUBSTRING([DATE_], 4, 4) AS[Year]," +
                                                  " [TOTAL_COMM] AS[Total_Commission]," +
                                                  " [CMA_COMM] AS[SAMA_Commission]," +
                                                  " [ARC_COMM] AS[ARC_Commission]," +
                                                  " [TRADE_COUNT] AS[Number_Of_Trades]," +
                                                  " [TOTAL_VALUE] AS[Total_Amount]" +
                                                  " FROM[ARC_Reports].[dbo].[commission_summary]");

            if (myDataTable != null)
                return (from DataRow x in myDataTable.Rows
                        select new CommissionSummary
                        {
                            CIC = Convert.ToDecimal(x["CIC"]),
                            Equator = x["EQUATOR"].ToString(),
                            Agent = x["AGENT"].ToString(),
                            Symbol = x["SYMBOL"].ToString(),
                            Month = Convert.ToInt32(x["Month"]),
                            Year = Convert.ToInt32(x["Year"]),
                            Total_Commission = Convert.ToDecimal(x["Total_Commission"]),
                            SAMA_Commission = Convert.ToDecimal(x["SAMA_Commission"]),
                            ARC_Commission = Convert.ToDecimal(x["ARC_Commission"]),
                            Number_Of_Trades = Convert.ToDecimal(x["Number_Of_Trades"]),
                            Total_Amount = Convert.ToDecimal(x["Total_Amount"]),
                        }).ToList();
            return null;
        }

        public static List<MarketShareGraphs> MarketShareGraphs(int pMarketType, int pDateType)
        {
            SqlParameter[] parameters = new SqlParameter[1];

            DataTable myDataTable = new DataTable();

            if (pMarketType == 0)
            {
                parameters[0] = new SqlParameter("@pMarketType", "SAM");

                if (pDateType == 1)
                    myDataTable = Helper.ExecuteReader("SELECT" +
                                                        " MAX([Percentage]) AS[Percentage], CONVERT(VARCHAR(5), [date], 108) AS[date] FROM MarketShare_Graphs" +
                                                        " WHERE[Type] = 'Value' AND[Market] = @pMarketType AND[date] >= CONVERT(DATE, GETDATE())" +
                                                        " GROUP BY CONVERT(VARCHAR(5), [date], 108)" +
                                                        " ORDER BY[date]", parameters);
                if (pDateType == 2)
                    myDataTable = Helper.ExecuteReader("SELECT TOP (5) [Percentage], [date] FROM [Rep_0011]" +
                                                        "WHERE[Type] = 'Value' AND[Market] = @pMarketType ORDER BY date DESC", parameters);
                else if (pDateType == 3)
                    myDataTable = Helper.ExecuteReader("SELECT TOP(30) [Percentage], [date] FROM [dbo].[Rep_0011] WHERE Market = @pMarketType AND [Type] = 'Value' ORDER BY [date] DESC", parameters);

                else if (pDateType == 4)
                    myDataTable = Helper.ExecuteReader("SELECT [Percentage], [date] FROM [dbo].[Rep_0011] WHERE Market = @pMarketType AND [Type] = 'Value' AND YEAR(date) = YEAR(GETDATE())", parameters);
            }
            else
            {
                parameters[0] = new SqlParameter("@pMarketType", "SEM");

                if (pDateType == 1)
                    myDataTable = Helper.ExecuteReader("SELECT" +
                                                        " MAX([Percentage]) AS[Percentage], CONVERT(VARCHAR(5), [date], 108) AS[date] FROM MarketShare_Graphs" +
                                                        " WHERE[Type] = 'Value' AND[Market] = @pMarketType AND[date] >= CONVERT(DATE, GETDATE())" +
                                                        " GROUP BY CONVERT(VARCHAR(5), [date], 108)" +
                                                        " ORDER BY[date]", parameters);
                if (pDateType == 2)
                    myDataTable = Helper.ExecuteReader("SELECT TOP (5) [Percentage], [date] FROM [Rep_0011]" +
                                                        "WHERE[Type] = 'Value' AND[Market] = @pMarketType ORDER BY date DESC", parameters);
                else if (pDateType == 3)
                    myDataTable = Helper.ExecuteReader("SELECT TOP(30) [Percentage], [date] FROM [dbo].[Rep_0011] WHERE Market = @pMarketType AND [Type] = 'Value' ORDER BY [date] DESC", parameters);
                else if (pDateType == 4)
                    myDataTable = Helper.ExecuteReader("SELECT [Percentage], [date] FROM [dbo].[Rep_0011] WHERE Market = @pMarketType AND [Type] = 'Value' AND YEAR(date) = YEAR(GETDATE())", parameters);
            }

            if (myDataTable != null)
                return (from DataRow x in myDataTable.Rows
                        select new MarketShareGraphs
                        {
                            //ETS_Share_Value = Convert.ToDouble(x["ETS_Share_Value"]),
                            //Market_Share_Value = Convert.ToDouble(x["Market_Share_Value"]),
                            Percentage = Convert.ToDouble(x["Percentage"]),
                            date = Convert.ToDateTime(x["date"]),
                            date2 = Convert.ToDateTime(x["date"])
                        }).ToList();
            return null;
        }

        public static List<MarketShareGraphs> MarketShareGraphsTrades(int pMarketType, int pDateType)
        {
            SqlParameter[] parameters = new SqlParameter[1];

            DataTable myDataTable = new DataTable();

            if (pMarketType == 0)
            {
                parameters[0] = new SqlParameter("@pMarketType", "SAM");

                if (pDateType == 1)
                    myDataTable = Helper.ExecuteReader("SELECT" +
                                                        " MAX([Percentage]) AS[Percentage], CONVERT(VARCHAR(5), [date], 108) AS[date] FROM MarketShare_Graphs" +
                                                        " WHERE[Type] = 'Trades' AND[Market] = @pMarketType AND[date] >= CONVERT(DATE, GETDATE())" +
                                                        " GROUP BY CONVERT(VARCHAR(5), [date], 108)" +
                                                        " ORDER BY[date]", parameters);
                if (pDateType == 2)
                    myDataTable = Helper.ExecuteReader("SELECT TOP (5) [Percentage], [date] FROM [Rep_0011]" +
                                                        "WHERE[Type] = 'Trades' AND[Market] = @pMarketType ORDER BY date DESC", parameters);
                else if (pDateType == 3)
                    myDataTable = Helper.ExecuteReader("SELECT TOP(30) [Percentage], [date] FROM [dbo].[Rep_0011] WHERE Market = @pMarketType AND [Type] = 'Trades' ORDER BY [date] DESC", parameters);

                else if (pDateType == 4)
                    myDataTable = Helper.ExecuteReader("SELECT [Percentage], [date] FROM [dbo].[Rep_0011] WHERE Market = @pMarketType AND [Type] = 'Trades' AND YEAR(date) = YEAR(GETDATE())", parameters);
            }
            else
            {
                parameters[0] = new SqlParameter("@pMarketType", "SEM");

                if (pDateType == 1)
                    myDataTable = Helper.ExecuteReader("SELECT" +
                                                        " MAX([Percentage]) AS[Percentage], CONVERT(VARCHAR(5), [date], 108) AS[date] FROM MarketShare_Graphs" +
                                                        " WHERE[Type] = 'Trades' AND[Market] = @pMarketType AND[date] >= CONVERT(DATE, GETDATE())" +
                                                        " GROUP BY CONVERT(VARCHAR(5), [date], 108)" +
                                                        " ORDER BY[date]", parameters);
                if (pDateType == 2)
                    myDataTable = Helper.ExecuteReader("SELECT TOP (5) [Percentage], [date] FROM [Rep_0011]" +
                                                        "WHERE[Type] = 'Trades' AND[Market] = @pMarketType ORDER BY date DESC", parameters);
                else if (pDateType == 3)
                    myDataTable = Helper.ExecuteReader("SELECT TOP(30) [Percentage], [date] FROM [dbo].[Rep_0011] WHERE Market = @pMarketType AND [Type] = 'Trades' ORDER BY [date] DESC", parameters);
                else if (pDateType == 4)
                    myDataTable = Helper.ExecuteReader("SELECT [Percentage], [date] FROM [dbo].[Rep_0011] WHERE Market = @pMarketType AND [Type] = 'Trades' AND YEAR(date) = YEAR(GETDATE())", parameters);
            }

            if (myDataTable != null)
                return (from DataRow x in myDataTable.Rows
                        select new MarketShareGraphs
                        {
                            //ETS_Share_Value = Convert.ToDouble(x["ETS_Share_Value"]),
                            //Market_Share_Value = Convert.ToDouble(x["Market_Share_Value"]),
                            Percentage = Convert.ToDouble(x["Percentage"]),
                            date = Convert.ToDateTime(x["date"]),
                            date2 = Convert.ToDateTime(x["date"])
                        }).ToList();
            return null;
        }

        public static List<MarketShareGraphs> MarketShareGraphsChannels(int pMarketType, int pDateType)
        {
            SqlParameter[] parameters = new SqlParameter[1];

            DataTable myDataTable = new DataTable();

            if (pMarketType == 0)
            {
                parameters[0] = new SqlParameter("@pMarketType", "SAM");
            }
            else
            {
                parameters[0] = new SqlParameter("@pMarketType", "SEM");
            }

            if (pDateType == 1)
                myDataTable = Helper.ExecuteReader(" SELECT Channel, MarketShare, SUBSTRING('JAN FEB MAR APR MAY JUN JUL AUG SEP OCT NOV DEC ', ([Month] * 4) - 3, 3) AS Month FROM[ARC_Reports].[dbo].[Rep_0012] WHERE [MarketType] = @pMarketType AND [Year] = YEAR(GETDATE()) AND Channel != 'AVG' AND MarketShare != 0 ORDER BY [Month]", parameters);
            else if (pDateType == 2)
                myDataTable = Helper.ExecuteReader(" SELECT[Channel], SUM([MarketShare])/ 3 AS[MarketShare], '1st' AS[Month] FROM[ARC_Reports].[dbo].[Rep_0012]" +
                                                    " WHERE[Month] IN(1, 2, 3) AND[MarketType] = @pMarketType AND[Year] = YEAR(GETDATE()) AND Channel != 'AVG' GROUP BY[Channel] HAVING MAX(Month) = 3" +
                                                    " UNION" +
                                                    " SELECT[Channel], SUM([MarketShare])/ 3 AS[MarketShare], '2st' AS[Month] FROM[ARC_Reports].[dbo].[Rep_0012]" +
                                                    " WHERE[Month] IN(4, 5, 6) AND[MarketType] = @pMarketType AND[Year] = YEAR(GETDATE()) AND Channel != 'AVG' GROUP BY[Channel] HAVING MAX(Month) = 6" +
                                                    " UNION" +
                                                    " SELECT[Channel], SUM([MarketShare])/ 3 AS[MarketShare], '3st' AS[Month] FROM[ARC_Reports].[dbo].[Rep_0012]" +
                                                    " WHERE[Month] IN(7, 8, 9) AND[MarketType] = @pMarketType AND[Year] = YEAR(GETDATE()) AND Channel != 'AVG' GROUP BY[Channel] HAVING MAX(Month) = 9" +
                                                    " UNION" +
                                                    " SELECT[Channel], SUM([MarketShare])/ 3 AS[MarketShare], '4st' AS[Month] FROM[ARC_Reports].[dbo].[Rep_0012]" +
                                                    " WHERE[Month] IN(10, 11, 12) AND[MarketType] = @pMarketType AND[Year] = YEAR(GETDATE()) AND Channel != 'AVG' GROUP BY[Channel] HAVING MAX(Month) = 12" +
                                                    " ORDER BY[Month]; ", parameters);
            else if (pDateType == 3)
                myDataTable = Helper.ExecuteReader(" SELECT[Channel], [MarketShare], YEAR(GETDATE()) - 1 AS 'Month' FROM[ARC_Reports].[dbo].[Rep_0013] WHERE[MarketType] = @pMarketType AND[Year] = YEAR(GETDATE()) - 1" +
                                                    " UNION" +
                                                    " SELECT[Channel], [MarketShare], YEAR(GETDATE()) - 2 AS 'Month' FROM[ARC_Reports].[dbo].[Rep_0013] WHERE[MarketType] = @pMarketType AND[Year] = YEAR(GETDATE()) - 2" +
                                                    " UNION" +
                                                    " SELECT[Channel], [MarketShare], YEAR(GETDATE()) - 3 AS 'Month' FROM[ARC_Reports].[dbo].[Rep_0013] WHERE[MarketType] = @pMarketType AND[Year] = YEAR(GETDATE()) - 3" +
                                                    " ORDER BY[Month]", parameters);
            if (myDataTable != null)
                return (from DataRow x in myDataTable.Rows
                        select new MarketShareGraphs
                        {
                            Channel = Helper.Channel(x["Channel"].ToString()),
                            MarketShare = Convert.ToDouble(x["MarketShare"]),
                            Month = x["Month"].ToString(),
                        }).ToList();
            return null;
        }

        public static List<MarketShareGraphs> MarketShareGraphsChannels_D(int pMarketType)
        {
            SqlParameter[] parameters = new SqlParameter[1];

            DataTable myDataTable = new DataTable();

            if (pMarketType == 0)
            {
                parameters[0] = new SqlParameter("@pMarketType", "SAM");
            }
            else
            {
                parameters[0] = new SqlParameter("@pMarketType", "SEM");
            }

            myDataTable = Helper.ExecuteReader(" SELECT Channel, SUM(TradeShare) AS TradeShare FROM[dbo].[Rep_001]" +
                                                    " WHERE convert(date, InsertedDate, 103) = convert(date, GETDATE(), 103) AND MarketType = @pMarketType" +
                                                    " GROUP BY Channel", parameters);

            if (myDataTable != null)
                return (from DataRow x in myDataTable.Rows
                        select new MarketShareGraphs
                        {
                            Channel = Helper.Channel(x["Channel"].ToString()),
                            TradeShare = Convert.ToDouble(x["TradeShare"]),
                        }).ToList();
            return null;
        }
        //public static List<Rep_001> Rep_emad(int pMarketType)
        //{
        //    SqlParameter[] parameters = new SqlParameter[1];

        //    DataTable myDataTable;

        //    if (pMarketType == 0)
        //    {
        //        parameters[0] = new SqlParameter("@pMarketType", "SAM");
        //        myDataTable = Helper.ExecuteReader("SELECT * FROM [dbo].[Rep_001] WHERE MarketType = @pMarketType", parameters);
        //    }
        //    else
        //    {
        //        parameters[0] = new SqlParameter("@pMarketType", "SEM");
        //        myDataTable = Helper.ExecuteReader("SELECT * FROM [dbo].[Rep_001] WHERE MarketType = @pMarketType", parameters);
        //    }

        //    if (myDataTable != null)
        //        return (from DataRow x in myDataTable.Rows
        //                select new Rep_001
        //                {
        //                    Id = (int)x["Id"],
        //                    Channel = Helper.Channel(x["Channel"].ToString()),
        //                    Operation = Helper.Operation(x["Operation"].ToString()),
        //                    Amount = Helper.ToGFormat(x["Amount"].ToString(), 2),
        //                    Transactions = (int)x["Transactions"],
        //                    Percentage = (double)x["Percentage"],
        //                    TradeShare = (double)x["TradeShare"],
        //                    MarketType = x["MarketType"].ToString(),
        //                    InsertedDate = Convert.ToDateTime(x["InsertedDate"])
        //                }).ToList();
        //    return null;
        //}
        //public static List<TestEnt> Test_01()
        //{
        //    return Helper.sqlDataReaderTest();
        //}

        //public static List<TestEnt> Test_02()
        //{
        //    return Helper.sqlDataAdapterTest();
        //}
    }
}