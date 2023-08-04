using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace WorkerService1;



    /// <summary>
    /// Inicializa una nueva instancia de la clase ApiClient.
    /// </summary>
    /// <param name="httpClient">Cliente HTTP inyectado.</param>
    /// <param name="apiParameters">Parámetros de la API.</param>
    public class ApiClient
    {
        private readonly HttpClient _httpClient;
        private readonly ApiParameters _apiParameters;
        private readonly JsonSerializerOptions _options;

        public ApiClient(HttpClient httpClient, ApiParameters apiParameters)
        {
            _httpClient = httpClient;
            _apiParameters = apiParameters;

            // Initialize JsonSerializerOptions
            _options = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            };

            // Add necessary headers for the API
            _httpClient.DefaultRequestHeaders.Add("Authorization", $"ABB {_apiParameters.ApiKey}");
            _httpClient.DefaultRequestHeaders.Add("Subscription-Key", _apiParameters.SubscriptionKey);
        }

       


    /// <summary>
    /// Envia una solicitud POST a la API.
    /// </summary>
    /// <param name="postData">Datos a enviar en el cuerpo de la solicitud.</param>
    public async Task SendRequest(PostData postData)
    {
        string url = $"https://api.electrification.ability.abb/abb-sdk-ext/api/{_apiParameters.ApplicationId}/{_apiParameters.PlantId}/APIparameters";

        var options = new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        };

        var json = System.Text.Json.JsonSerializer.Serialize(postData, options);
        var data = new StringContent(json, Encoding.UTF8, "application/json");

        Console.WriteLine(url);
        // Print JSON to the console
        Console.WriteLine(json);
        // Print JSON to the console
        Console.WriteLine(data.ToString());

        var response = await _httpClient.PostAsync(url, data);

      

        string result = await response.Content.ReadAsStringAsync();
        Console.WriteLine(result);
    }

}
