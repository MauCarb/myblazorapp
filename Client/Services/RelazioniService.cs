using BlazorApp.Shared;
using System.Net.Http.Json;

public class RelazioniService
{
    private readonly HttpClient _httpClient;

    public RelazioniService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<Relazioni> GetRelazione(decimal id)
    {
        return await _httpClient.GetFromJsonAsync<Relazioni>($"https://ophthalapi02-dcafg8d7hhekfkb0.italynorth-01.azurewebsites.net/api/relaz/{id}");
    }

    public async Task AddRelazione(Relazioni relazione)
    {
        await _httpClient.PostAsJsonAsync("https://ophthalapi02-dcafg8d7hhekfkb0.italynorth-01.azurewebsites.net/api/relaz", relazione);
    }

    public async Task UpdRelazione(decimal id, Relazioni relazione)
    {
        await _httpClient.PutAsJsonAsync($"https://ophthalapi02-dcafg8d7hhekfkb0.italynorth-01.azurewebsites.net/api/relaz/{relazione.IdRelazione}", relazione);
    }
}
