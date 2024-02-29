
namespace Crezco_Interview_CSharp.Services
{
    public class IPCountryStorageService : IIPCountryStorageService
    {
        private Dictionary<string, int> _countriesSummary;
        public IPCountryStorageService() {
            _countriesSummary = new Dictionary<string, int>();
        }

        public Dictionary<string, int> GetCountriesSummary()
        {
            throw new NotImplementedException();
        }

        public void IncrementCountry(string country)
        {
            var keyExists = _countriesSummary.TryGetValue(country, out var value);

            var newValue= 1;

            if (keyExists)
            {
                newValue = value + 1;
            }

            _countriesSummary[country] = newValue;
        }
    }
}
