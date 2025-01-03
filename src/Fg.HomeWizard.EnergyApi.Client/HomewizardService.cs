using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Fg.HomeWizard.EnergyApi.Client
{
    public class HomeWizardService : IHomeWizardService
    {
        private readonly HttpClient _http;

        [Obsolete("Use constructor that accepts a HttpClient instead")]
        public HomeWizardService(HomeWizardDevice p1Meter) : this(p1Meter, new HttpClient())
        {
        }

        public HomeWizardService(HomeWizardDevice p1Meter, HttpClient httpClient)
        {
            _http = httpClient;
            _http.BaseAddress = new Uri($"http://{p1Meter.IPAddress}/api/");
        }

        public async Task<Measurement> GetCurrentMeasurementsAsync()
        {
            var response = await _http.GetAsync("v1/data");

            if (response.IsSuccessStatusCode == false)
            {
                throw new HttpRequestException(
                    $"Request to retrieve HomeWizard data failed with statuscode {response.StatusCode}");
            }

            var json = await response.Content.ReadAsStringAsync();

            var measurement = JsonSerializer.Deserialize<Measurement>(json);
            
            if (measurement == null)
            {
                throw new InvalidOperationException("Unable to deserialize response to model");
            }

            measurement.Timestamp = DateTimeOffset.UtcNow;

            return measurement;
        }
    }
}
