
namespace Crezco_Interview_CSharp.Services
{
    public class IPCountryService : IIPInformationService
    {
        private readonly HttpClient _httpClient;
        private readonly string SUCCESS_STATUS = "success";

        public IPCountryService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }


        public async Task<string?> GetInfoAsync(string ipAddress)
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<IPCountryResponse>(ipAddress + "?fields=49153");

                if (result == null || !result.status.Equals(SUCCESS_STATUS))
                {
                    return null;
                }

                return result?.country;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public Task<string?> GetSummary()
        {
            throw new NotImplementedException();
        }
    }
}
