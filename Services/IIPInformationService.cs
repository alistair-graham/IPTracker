namespace Crezco_Interview_CSharp.Services
{
    public interface IIPInformationService
    {
        public Task<string?> GetInfoAsync(string ipAddress);
        public Task<string> GetSummary();
    }
}
