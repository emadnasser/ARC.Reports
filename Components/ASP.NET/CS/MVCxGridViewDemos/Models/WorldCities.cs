using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DevExpress.Web.Demos {
    public static class WorldCitiesDataProvider {
        const string WorldCitiesDataContextKey = "DXWorldCitiesDataContext";

        public static WorldCitiesContext DB {
            get {
                if(HttpContext.Current.Items[WorldCitiesDataContextKey] == null)
                    HttpContext.Current.Items[WorldCitiesDataContextKey] = new WorldCitiesContext();
                return (WorldCitiesContext)HttpContext.Current.Items[WorldCitiesDataContextKey];
            }
        }

        public static IEnumerable<Country> GetCountries() {
            return DB.Countries
                .OrderBy(c => c.CountryName)
                .ToList();
        }
        public static IEnumerable<City> GetCities() {
            return GetCities(null);
        }
        public static IEnumerable<City> GetCities(string countryName) {
            return DB.Cities
                .Where(c => string.IsNullOrEmpty(countryName) || c.Country.CountryName == countryName)
                .OrderBy(c => c.CityName)
                .GroupBy(c => c.CityName)
                .Select(g => g.FirstOrDefault())
                .ToList();
        }
    }
}
