using Microsoft.AspNetCore.Mvc;
using TrainigCourses.Models;
using TrainigCourses.Services;

namespace TrainigCourses.Controllers
{
    [Route("api/[controller]")]
    public class CoursesController : Controller
    {
        private readonly ICourse _course;
        public CoursesController(ICourse course)
        {
            _course = course;
        }

        [HttpGet]
        public IEnumerable<Course> Get()
        {
            return _course.GetAll();
        }

        [HttpGet("{id}")]
        public Course Get(int id)
        {
            return _course.Get(id);
        }

        [HttpPost]
        public int Post([FromBody] Course course)
        {
            return _course.Add(course);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Course model)
        {
            var course = _course.Get(id);
            course.Title = model.Title; course.Hours = model.Hours;
            _course.Save(course);
        }

        [HttpDelete("{id}")]
        public void Delete(int id) 
        {
            var course = _course.Get(id);
            _course.Delete(course);
        }
    }
}
