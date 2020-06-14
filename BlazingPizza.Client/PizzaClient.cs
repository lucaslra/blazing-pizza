using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BlazingPizza.Client
{
    public class PizzaClient
    {
        private readonly HttpClient httpClient;

        public PizzaClient(HttpClient httpClient) => this.httpClient = httpClient;

        public async Task<IEnumerable<PizzaSpecial>> GetSpecials() => await httpClient.GetFromJsonAsync<IEnumerable<PizzaSpecial>>("specials");

        public async Task<IEnumerable<Topping>> GetToppings() => await httpClient.GetFromJsonAsync<IEnumerable<Topping>>("toppings");
    }
}
