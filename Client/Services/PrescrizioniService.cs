using BlazorApp.Shared;
using System.Net.Http.Json;

public class PrescrizioniService
{
    private readonly HttpClient _httpClient;

    public PrescrizioniService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<Prescrizioni>> GetPrescrByVisit(decimal id)
    {
        return await _httpClient.GetFromJsonAsync<List<Prescrizioni>>($"https://ophthalapi02-dcafg8d7hhekfkb0.italynorth-01.azurewebsites.net/api/presc/{id}");
    }

    public async Task<Prescrizione> PostPrescrizione(Prescrizione presc)
    {
        var response = await _httpClient.PostAsJsonAsync("https://ophthalapi02-dcafg8d7hhekfkb0.italynorth-01.azurewebsites.net/api/presc", presc);

        // Assicurati che la risposta sia valida
        response.EnsureSuccessStatusCode();

        // Leggi e restituisci l'oggetto Prescrizione creato
        return await response.Content.ReadFromJsonAsync<Prescrizione>();
    }

    public async Task PutPrescrizione(decimal id, Prescrizione presc)
    {
        await _httpClient.PutAsJsonAsync($"https://ophthalapi02-dcafg8d7hhekfkb0.italynorth-01.azurewebsites.net/api/presc/{presc.IdPrescrizione}", presc);
    }

    public async Task DeletePrescrizione(decimal id)
    {
        await _httpClient.DeleteAsync($"https://ophthalapi02-dcafg8d7hhekfkb0.italynorth-01.azurewebsites.net/api/presc/{id}");
    }
}
