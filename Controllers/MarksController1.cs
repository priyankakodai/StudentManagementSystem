using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using StudentWebApp.Models;
using StudentWebApp.Services;
using System.Text;

namespace StudentWebApp.Controllers
{
    public class MarksController : Controller
    {
        private readonly string apiBase = "http://localhost:5208/api/Marks";

        private readonly MarksService _service;

        public MarksController(MarksService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index(int? id = null)
        {
            using var client = new HttpClient();
            var response = await client.GetStringAsync(apiBase + "/GetAllMarks");
            var marksList = JsonConvert.DeserializeObject<List<Marks>>(response);

            if (id.HasValue)
            {
                // FIXED HERE ⬇⬇⬇⬇⬇
                var mark = marksList.FirstOrDefault(m => m.Id == id.Value);

                if (mark != null)
                {
                    mark.Total = mark.Tamil + mark.English + mark.Maths + mark.Science + mark.Social;
                }
            }

            return View(marksList);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Marks model)
        {
            using var client = new HttpClient();
            var jsonData = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            await client.PostAsync(apiBase + "/AddMarks", jsonData);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult CalculateMarks(int id)
        {
            return RedirectToAction("Index", new { id = id });
        }

        public async Task<IActionResult> Delete(int id)
        {
            var mark = await _service.GetMarkById(id);
            if (mark == null)
                return NotFound();

            return View(mark);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _service.DeleteMark(id);
            return RedirectToAction("Index");
        }

    }
}
