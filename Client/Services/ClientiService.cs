using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Collections.Generic;
using BlazorApp.Shared;
using static System.Net.WebRequestMethods;

public class ClientiService
{
    private readonly HttpClient _httpClient;

    public ClientiService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<Clienti>> GetClienti()
    {
        return await _httpClient.GetFromJsonAsync<List<Clienti>>("https://ophthalapi02-dcafg8d7hhekfkb0.italynorth-01.azurewebsites.net/api/clienti");

        // var clienti = await Http.GetFromJsonAsync<List<Cliente>>("http://localhost:7214/api/clienti");
    }

    public async Task<Clienti> GetCliente(decimal id)
    {
        return await _httpClient.GetFromJsonAsync<Clienti>($"https://ophthalapi02-dcafg8d7hhekfkb0.italynorth-01.azurewebsites.net/api/clienti/{id}");
    }

    public async Task AddCliente(Clienti cliente)
    {
        await _httpClient.PostAsJsonAsync("https://ophthalapi02-dcafg8d7hhekfkb0.italynorth-01.azurewebsites.net/api/clienti", cliente);
    }

    public async Task UpdateCliente(Clienti cliente)
    {
        await _httpClient.PutAsJsonAsync($"https://ophthalapi02-dcafg8d7hhekfkb0.italynorth-01.azurewebsites.net/api/clienti/{cliente.Id}", cliente);
    }

    public async Task DeleteCliente(decimal id)
    {
        await _httpClient.DeleteAsync($"https://ophthalapi02-dcafg8d7hhekfkb0.italynorth-01.azurewebsites.net/api/clienti/{id}");
    }
}
