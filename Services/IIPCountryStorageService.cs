namespace Crezco_Interview_CSharp.Services
{
    public interface IIPCountryStorageService
    {
        public void IncrementCountry(string country);

        public Dictionary<string, int> GetCountriesSummary();
    }
}
