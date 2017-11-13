﻿using System.Collections.Generic;

namespace DevExpress.Web.Demos {
    public static class WidgetsDemoHelper {
        public static List<CurrencyRate> GetCurrencyRates() {
            return Trading.GetCurrencyRates();
        }
        public static List<DayControl> GetDayControls() {
            return WeatherWidget.GetDayControls();
        }
        public static List<string> GetMailFolders() {
            return new List<string>() { "Inbox(1)", "Outbox", "Sent Items", "Deleted Items", "Drafts" };
        }
        public static List<MarketLeader> GetMarketLeaders() {
            return Trading.GetMarketLeaders();
        }
        public static List<string> GetWidgets() {
            return new List<string>() { "DateTime", "Mail", "Trading", "Weather", "Calendar" };
        }
    }
}