using BlazorApp.Shared;
using System.Net.Http.Json;

public class PatientMngService
{
    private readonly HttpClient _httpClient;

    public PatientMngService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<Patient> GetPatient(decimal id)
    {
        return await _httpClient.GetFromJsonAsync<Patient>($"https://ophthalapi02-dcafg8d7hhekfkb0.italynorth-01.azurewebsites.net/api/patient/{id}");
    }

    public async Task<Patient> AddPatient(Patient paziente)
    {
        //await _httpClient.PostAsJsonAsync("https://ophthalapi02-dcafg8d7hhekfkb0.italynorth-01.azurewebsites.net/api/patient", paziente);
        var response = await _httpClient.PostAsJsonAsync("https://ophthalapi02-dcafg8d7hhekfkb0.italynorth-01.azurewebsites.net/api/patient", paziente);

        // Assicurati che la risposta sia valida
        response.EnsureSuccessStatusCode();

        // Leggi e restituisci l'oggetto Patient creato
        return await response.Content.ReadFromJsonAsync<Patient>();
    }

    //public async Task<decimal> AddPatient(Patient paziente)
    //{
    //    var response = _httpClient.PostAsJsonAsync("https://ophthalapi02-dcafg8d7hhekfkb0.italynorth-01.azurewebsites.net/api/patient", paziente);

    //    // Assicurati che la richiesta sia andata a buon fine
    //    response.EnsureSuccessStatusCode();
    //}

    public async Task UpdPatient(decimal id, Patient paziente)
    {
        await _httpClient.PutAsJsonAsync($"https://ophthalapi02-dcafg8d7hhekfkb0.italynorth-01.azurewebsites.net/api/patient/{paziente.IdPatient}", paziente);
    }

    public async Task DeletePatient(decimal id)
    {
        await _httpClient.DeleteAsync($"https://ophthalapi02-dcafg8d7hhekfkb0.italynorth-01.azurewebsites.net/api/patient/{id}");
    }
}
