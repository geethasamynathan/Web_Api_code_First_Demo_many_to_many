using Microsoft.AspNetCore.Mvc;
using Web_Api_code_First_Demo_many_to_many.Models;
using Web_Api_code_First_Demo_many_to_many.Repositories;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Web_Api_code_First_Demo_many_to_many.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        private readonly IStudentCourseRepo _repo;
        public CoursesController(IStudentCourseRepo repo)
        {
                _repo = repo;
        }
        // GET: api/<CoursesController>
        [HttpGet]
        public ActionResult Get()
        {
            List<Course> courses = new List<Course>();
             courses = _repo.GetCourses();
                if(courses.Count>0)
                {
                    return Ok(courses);
                }
                else
                {
                    return NoContent();
                }  
        }

        // GET api/<CoursesController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            if(FindById(id))
                return Ok(_repo.GetCourse(id));
            else
                return NotFound();
        }

        // POST api/<CoursesController>
        [HttpPost]
        public ActionResult Post([FromBody] Course course)
        {
            Course addedCourse = _repo.CreateCourse(course);
            if(addedCourse!=null)
            {
                return Ok(addedCourse);
            }
            else
            {
                return BadRequest();
            }
        }

        // PUT api/<CoursesController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id,Course course)
        {

            if (FindById(course.CourseId))
            {
                _repo.UpdateCourse(course);
                return Ok(course);
            }            
            else
            {
                return BadRequest();
            }
        }

        // DELETE api/<CoursesController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            if(FindById(id))
            {  _repo.DeleteCourse(id);
            return Ok("Record Removed successfully");
            }
            else
            { return NoContent(); } 
        }
        [NonAction]
        [HttpGet]
        public bool FindById(int id)
        {
          
                Course course = _repo.GetCourse(id);
                if (course != null)
                    return true;
            
            else
                return false;
        }
    }
}
