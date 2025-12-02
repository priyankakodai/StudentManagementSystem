using Microsoft.AspNetCore.Mvc;
using StudentWebApp.Models;
using StudentWebApp.Services;

namespace StudentWebApp.Controllers
{
    public class StudentsController : Controller
    {
        private readonly StudentService _service;

        public StudentsController(StudentService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var students = await _service.GetAllStudent();
            return View(students);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Student student)
        {
            if (!ModelState.IsValid)
                return View(student);

            await _service.CreateStudent(student);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Edit(int id)
        {
            var student = await _service.GetStudentById(id);
            if (student == null)
                return NotFound();

            return View(student);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, Student student)
        {
            if (!ModelState.IsValid)
                return View(student);

            await _service.UpdateStudent(id, student);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Details(int id)
        {
            var student = await _service.GetStudentById(id);
            if (student == null)
                return NotFound();

            return View(student);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var student = await _service.GetStudentById(id);
            if (student == null)
                return NotFound();

            return View(student);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _service.DeleteStudent(id);
            return RedirectToAction("Index");
        }
    }
}
