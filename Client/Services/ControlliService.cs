using BlazorApp.Shared;
using System.Net.Http.Json;

public class ControlliService
{
    private readonly HttpClient _httpClient;

    public ControlliService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<Controlli> GetControllo(decimal id)
    {
        return await _httpClient.GetFromJsonAsync<Controlli>($"https://ophthalapi02-dcafg8d7hhekfkb0.italynorth-01.azurewebsites.net/api/cntr/{id}");
    }

    public async Task AddControllo(Controlli controllo)
    {
        await _httpClient.PostAsJsonAsync("https://ophthalapi02-dcafg8d7hhekfkb0.italynorth-01.azurewebsites.net/api/cntr", controllo);
    }

    public async Task UpdControllo(decimal id, Controlli controllo)
    {
        await _httpClient.PutAsJsonAsync($"https://ophthalapi02-dcafg8d7hhekfkb0.italynorth-01.azurewebsites.net/api/cntr/{controllo.IdControllo}", controllo);
    }
}
