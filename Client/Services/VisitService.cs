using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
using BlazorApp.Shared;

public class VisitService
{
	private readonly HttpClient _httpClient;

	public VisitService(HttpClient httpClient)
	{
		_httpClient = httpClient;
	}

	//public async Task<List<Coppia>> ListPatientsVisits(decimal id)
	//{
	//	//return await _httpClient.GetFromJsonAsync<List<Coppia>>($"https://ophthalapi02-dcafg8d7hhekfkb0.italynorth-01.azurewebsites.net/api/visit/{id}");

 //       // Configura le opzioni di deserializzazione (ad esempio, per gestire date in modo corretto)
 //       var options = new JsonSerializerOptions
 //       {
 //           PropertyNameCaseInsensitive = true,  // Ignora il case delle proprietà
 //           DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull, // Ignora campi nulli
 //           Converters = { new System.Text.Json.Serialization.JsonStringEnumConverter() }  // Aggiungi altre configurazioni se necessario
 //       };

 //       var response = await _httpClient.GetAsync($"https://ophthalapi02-dcafg8d7hhekfkb0.italynorth-01.azurewebsites.net/api/visit/{id}");

 //       if (response.IsSuccessStatusCode)
 //       {
 //           // Usa esplicitamente il JsonSerializer per maggiore controllo
 //           var jsonContent = await response.Content.ReadAsStringAsync();
 //           return JsonSerializer.Deserialize<List<Coppia>>(jsonContent, options);
 //       }
 //       else
 //       {
 //           throw new Exception("Errore nella chiamata API");
 //       }
 //   }

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
