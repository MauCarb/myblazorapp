using BlazorApp.Shared;
using System.Net.Http.Json;

public class ListControlliService
{
    private readonly HttpClient _httpClient;

    public ListControlliService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<TriplaDecDatStr>> ListControlliByVisit(decimal id)
    {
        //return await _httpClient.GetFromJsonAsync<List<CoppiaDecDat>>($"https://ophthalapi02-dcafg8d7hhekfkb0.italynorth-01.azurewebsites.net/api/lstcntr/{id}");

        return await _httpClient.GetFromJsonAsync<List<TriplaDecDatStr>>($"https://ophthalapi02-dcafg8d7hhekfkb0.italynorth-01.azurewebsites.net/api/lstcntr/{id}");
    }
}
