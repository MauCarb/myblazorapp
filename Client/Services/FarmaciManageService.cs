using BlazorApp.Shared;
using System.Net.Http.Json;

public class FarmaciManageService
{
    private readonly HttpClient _httpClient;

    public FarmaciManageService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<Farmaci> GetFarmaco(decimal id)
    {
        return await _httpClient.GetFromJsonAsync<Farmaci>($"https://ophthalapi02-dcafg8d7hhekfkb0.italynorth-01.azurewebsites.net/api/farmacimng/{id}");
    }

    public async Task<Farmaci> PostFarmaco(Farmaci far)
    {
        var response = await _httpClient.PostAsJsonAsync("https://ophthalapi02-dcafg8d7hhekfkb0.italynorth-01.azurewebsites.net/api/farmacimng", far);

        // Assicurati che la risposta sia valida
        response.EnsureSuccessStatusCode();

        // Leggi e restituisci l'oggetto Prescrizione creato
        return await response.Content.ReadFromJsonAsync<Farmaci>();
    }

    public async Task PutFarmaco(decimal id, Farmaci far)
    {
        await _httpClient.PutAsJsonAsync($"https://ophthalapi02-dcafg8d7hhekfkb0.italynorth-01.azurewebsites.net/api/farmacimng/{far.IdFarmaco}", far);
    }

    public async Task DeleteFarmaco(decimal id)
    {
        await _httpClient.DeleteAsync($"https://ophthalapi02-dcafg8d7hhekfkb0.italynorth-01.azurewebsites.net/api/farmacimng/{id}");
    }
}
