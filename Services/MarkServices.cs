using Newtonsoft.Json;
using StudentWebApp.Models;
using System.Text;

namespace StudentWebApp.Services
{
    public class MarksService
    {
        private readonly HttpClient _client;

        public MarksService(IHttpClientFactory httpClientFactory)
        {
            _client = httpClientFactory.CreateClient("StudentAPI");
        }

        public async Task<bool> AddMarks(Marks marks)
        {
            var content = new StringContent(JsonConvert.SerializeObject(marks),
                                            Encoding.UTF8,
                                            "application/json");

            var response = await _client.PostAsync("Marks", content);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> CalculateMarks(int studentId)
        {
            var response = await _client.PostAsync($"Marks/Calculate/{studentId}", null);
            return response.IsSuccessStatusCode;
        }

        public async Task<Marks> GetMarkById(int id)
        {
            var response = await _client.GetAsync($"Marks/{id}");
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadFromJsonAsync<Marks>();
        }

        public async Task<bool> DeleteMark(int id)
        {
            var response = await _client.DeleteAsync($"Marks/{id}");
            return response.IsSuccessStatusCode;
        }
    }
}
