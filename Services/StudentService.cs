using StudentWebApp.Models;
using System.Text;
using System.Text.Json;

namespace StudentWebApp.Services
{
    public class StudentService
    {
        private readonly HttpClient _client;

        public StudentService(IHttpClientFactory httpClientFactory)
        {
            _client = httpClientFactory.CreateClient("StudentAPI");
        }

        public async Task<List<Student>> GetAllStudent()
        {
            var response = await _client.GetAsync("Students");
            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<List<Student>>(json, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }

        public async Task<Student?> GetStudentById(int id)
        {
            var response = await _client.GetAsync($"Students/{id}");

            if (!response.IsSuccessStatusCode)
                return null;

            var json = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<Student>(json, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }

        public async Task<bool> CreateStudent(Student student)
        {
            var jsonData = new StringContent(JsonSerializer.Serialize(student), Encoding.UTF8, "application/json");
            var response = await _client.PostAsync("Students", jsonData);

            return response.IsSuccessStatusCode;
        }

        public async Task<bool> UpdateStudent(int id, Student student)
        {
            var jsonData = new StringContent(JsonSerializer.Serialize(student), Encoding.UTF8, "application/json");
            var response = await _client.PutAsync($"Students/{id}", jsonData);

            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteStudent(int id)
        {
            var response = await _client.DeleteAsync($"Students/{id}");
            return response.IsSuccessStatusCode;
        }
    }
}
