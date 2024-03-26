using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace Web_Api_code_First_Demo_many_to_many.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string CourseDuration { get; set; }
        public string CourseTutor { get; set; }
        public decimal CourseFee { get; set; }       
        public  ICollection<Student>? Students{ get; set; }
    }
}
