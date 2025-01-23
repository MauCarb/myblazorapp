using BlazorApp.Shared;
using System.Net.Http.Json;

public class ListDrugsService
{
    private readonly HttpClient _httpClient;

    public ListDrugsService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<DrugSearch>> ListDrugsAndUse(string far)
    {
        return await _httpClient.GetFromJsonAsync<List<DrugSearch>>($"https://ophthalapi02-dcafg8d7hhekfkb0.italynorth-01.azurewebsites.net/api/lstdrugs/{far}");
    }
}
