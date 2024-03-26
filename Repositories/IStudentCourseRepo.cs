using Web_Api_code_First_Demo_many_to_many.Models;

namespace Web_Api_code_First_Demo_many_to_many.Repositories
{
    public interface IStudentCourseRepo
    {
        public List<Student> GetStudents();
        public Student GetStudent(int id);
        public Student CreateStudent(Student student);       
        public Student UpdateStudent(Student student);
        public void DeleteStudent(int id);
        public List<Course> GetCourses();
        public Course GetCourse(int id);
        public Course CreateCourse(Course course);
        public Course UpdateCourse(Course course);
        public void DeleteCourse(int id);

    }
}
