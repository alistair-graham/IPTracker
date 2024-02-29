namespace Crezco_Interview_CSharp.Services
{
    public record IPCountryResponse
    {
        public string status { get; set; }
        public string message { get; set; }
        public string country { get; set; }
    }
}
