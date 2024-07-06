using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.IO;
using System.Net;

namespace Pre_Entrega_Proyecto_final.ApiServices
{
    public class ApiService
    {
        private readonly HttpClient _client;

        public ApiService()
        {
            _client = new HttpClient();

            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            IConfiguration configuration = builder.Build();

            string apiUrl = configuration["ApiBaseUrl"];

            if (string.IsNullOrEmpty(apiUrl))
            {
                throw new Exception("La URL de la API no está configurada en appsettings.json.");
            }

            _client.BaseAddress = new Uri(apiUrl);
        }

        public async Task<string> GetDataAsync(string endpoint)
        {
            HttpResponseMessage response = await _client.GetAsync(endpoint);
            response.EnsureSuccessStatusCode(); 

            return await response.Content.ReadAsStringAsync();
        }

        public async Task<HttpResponseMessage> PostDataAsync(string url, HttpContent content)
        {
            return await _client.PostAsync(url, content);
        }

        public async Task<HttpResponseMessage> PutDataAsync(string endpoint, HttpContent content)
        {
            try
            {
                HttpResponseMessage response = await _client.PutAsync(endpoint, content);
                response.EnsureSuccessStatusCode(); 

                return response;
            }
            catch (HttpRequestException ex)
            {
                throw new Exception("Error en la solicitud HTTP: " + ex.Message);
            }
        }

        public async Task<bool> DeleteDataAsync(string endpoint)
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Delete, endpoint);

                HttpResponseMessage response = await _client.SendAsync(request);

                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else if (response.StatusCode == HttpStatusCode.NotFound)
                {
                    throw new Exception("El recurso que intenta eliminar no se encontró (404 Not Found).");
                }
                else
                {
                    throw new Exception($"Error en la solicitud HTTP: {response.StatusCode} - {response.ReasonPhrase}");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception("Error en la solicitud HTTP: " + ex.Message);
            }
        }
    }
}