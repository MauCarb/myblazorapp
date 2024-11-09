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

    public async Task AddPatient(Patient paziente)
    {
        await _httpClient.PostAsJsonAsync("https://ophthalapi02-dcafg8d7hhekfkb0.italynorth-01.azurewebsites.net/api/patient", paziente);
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
}
