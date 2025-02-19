using BlazorApp.Shared;
using System.Net.Http.Json;

public class FarmaciUsoListService
{
    private readonly HttpClient _httpClient;

    public FarmaciUsoListService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<FarmaciUso>> ListFarmaciUso(decimal idf)
    {
        return await _httpClient.GetFromJsonAsync<List<FarmaciUso>>($"https://ophthalapi02-dcafg8d7hhekfkb0.italynorth-01.azurewebsites.net/api/farmaciusolst/{idf}");
    }
}
