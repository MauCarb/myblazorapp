using BlazorApp.Shared;
using System.Net.Http.Json;

public class FarmaciUsoManageService
{
    private readonly HttpClient _httpClient;

    public FarmaciUsoManageService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<FarmaciUso> GetFarmacoUso(decimal id)
    {
        return await _httpClient.GetFromJsonAsync<FarmaciUso>($"https://ophthalapi02-dcafg8d7hhekfkb0.italynorth-01.azurewebsites.net/api/farmaciusomng/{id}");
    }

    public async Task<FarmaciUso> PostFarmacoUso(FarmaciUso ufar)
    {
        var response = await _httpClient.PostAsJsonAsync("https://ophthalapi02-dcafg8d7hhekfkb0.italynorth-01.azurewebsites.net/api/farmaciusomng", ufar);

        // Assicurati che la risposta sia valida
        response.EnsureSuccessStatusCode();

        // Leggi e restituisci l'oggetto Prescrizione creato
        return await response.Content.ReadFromJsonAsync<FarmaciUso>();
    }

    public async Task PutFarmacoUso(decimal id, FarmaciUso ufar)
    {
        await _httpClient.PutAsJsonAsync($"https://ophthalapi02-dcafg8d7hhekfkb0.italynorth-01.azurewebsites.net/api/farmaciusomng/{ufar.IdFarmacoUso}", ufar);
    }

    public async Task DeleteFarmacoUso(decimal id)
    {
        await _httpClient.DeleteAsync($"https://ophthalapi02-dcafg8d7hhekfkb0.italynorth-01.azurewebsites.net/api/farmaciusomng/{id}");
    }
}
