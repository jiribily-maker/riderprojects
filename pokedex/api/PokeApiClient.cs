using System.Net.Http.Json;
using System.Text.Json;

namespace Pokedex.Api;

public class PokeApiClient
{
    private static readonly JsonSerializerOptions JsonOpts = new()
    {
        PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseLower
    };
    private readonly HttpClient _http = new HttpClient()
    {
        BaseAddress = new Uri("https://pokeapi.co/api/v2/"),
    };
    public async Task<LocationAreaPage> GetLocationAreasAsync(string? pageUrl = null)
    {
        var url = pageUrl ?? "location-area";
        var page = await _http.GetFromJsonAsync<LocationAreaPage>(url, JsonOpts);
        return page ?? throw new InvalidOperationException("Empty response");
    }
}