using BlazorApp.Shared;
using System.Net.Http.Json;

public class PrivacySignService
{
    private readonly HttpClient _httpClient;

    public PrivacySignService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<PrivacySign> AddPrivacySign(PrivacySign stuffsign)
    {
        var response = await _httpClient.PostAsJsonAsync("https://ophthalapi02-dcafg8d7hhekfkb0.italynorth-01.azurewebsites.net/api/privacysign", stuffsign);

        // Assicurati che la risposta sia valida
        response.EnsureSuccessStatusCode();

        // Leggi e restituisci l'oggetto PrivacySign creato
        return await response.Content.ReadFromJsonAsync<PrivacySign>();
    }

    public async Task DeletePrivacySign(decimal id)
    {
        await _httpClient.DeleteAsync($"https://ophthalapi02-dcafg8d7hhekfkb0.italynorth-01.azurewebsites.net/api/privacysign/{id}");
    }
}
