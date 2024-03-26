namespace Web_Api_code_First_Demo_many_to_many.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int StudentAge { get; set;}
        public string StudentGender { get; set; }
        public long StudentPhone { get; set;}
        public string StudentEmail { get; set; }
        public  ICollection<Course>? Courses { get; set; }
    
    }
}
