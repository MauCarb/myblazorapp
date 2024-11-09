using BlazorApp.Shared;
using System.Net.Http.Json;

public class VisitService
{
	private readonly HttpClient _httpClient;

	public VisitService(HttpClient httpClient)
	{
		_httpClient = httpClient;
	}

	public async Task<Visit> GetVisit(decimal id)
	{
		return await _httpClient.GetFromJsonAsync<Visit>($"https://ophthalapi02-dcafg8d7hhekfkb0.italynorth-01.azurewebsites.net/api/visit/{id}");
	}

    public async Task AddVisit(Visit visita)
    {
        await _httpClient.PostAsJsonAsync("https://ophthalapi02-dcafg8d7hhekfkb0.italynorth-01.azurewebsites.net/api/visit", visita);
    }

    public async Task UpdVisit(decimal id, Visit visita)
    {
        await _httpClient.PutAsJsonAsync($"https://ophthalapi02-dcafg8d7hhekfkb0.italynorth-01.azurewebsites.net/api/visit/{visita.IdVisit}", visita);
    }
}
