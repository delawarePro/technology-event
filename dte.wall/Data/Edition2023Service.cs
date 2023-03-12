using System.Text.Json;

namespace dte.wall.Data;

/// <summary>
/// Data service for 2023 delaware Technology Event
/// </summary>
public class Edition2023Service
{
    private readonly HttpClient _client;

    public Edition2023Service(IHttpClientFactory httpClientFactory)
    {
        if (httpClientFactory is null)
        {
            throw new ArgumentNullException(nameof(httpClientFactory));
        }

        _client = httpClientFactory.CreateClient("2023");
    }

    public async Task<ConferenceData> GetConferenceDataAsync()
    {
        var response = await _client.GetAsync("view/All");
        response.EnsureSuccessStatusCode();
        return await response.Content.ReadFromJsonAsync<ConferenceData>(new JsonSerializerOptions(JsonSerializerDefaults.Web));
    }
}

