using BlazorApp.Shared;
using System.Net.Http.Json;

public class PatientService
{
    private readonly HttpClient _httpClient;

    public PatientService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<Patient>> PatList(string p)
    {
        return await _httpClient.GetFromJsonAsync<List<Patient>>($"https://ophthalapi02-dcafg8d7hhekfkb0.italynorth-01.azurewebsites.net/api/patients/{p}");
    }
}
