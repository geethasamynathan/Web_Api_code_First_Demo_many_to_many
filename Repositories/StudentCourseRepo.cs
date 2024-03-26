using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using Web_Api_code_First_Demo_many_to_many.Models;

namespace Web_Api_code_First_Demo_many_to_many.Repositories
{
    public class StudentCourseRepo : IStudentCourseRepo
    {
        private readonly StudentCourseDbContext _context;
        public StudentCourseRepo(StudentCourseDbContext context)
        {
            _context = context;
        }
        public Course CreateCourse(Course course)
        {
            try
            {
                if (course != null)
                {
                    _context.Courses.Add(course);
                    _context.SaveChanges();
                   
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return course;
        }

        public Student CreateStudent(Student student)
        {
            try
            {
                if (student != null)
                {
                    _context.Students.Add(student);
                    _context.SaveChanges();

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return student;
        }

        public void DeleteCourse(int id)
        {
            Course courseToDelete=_context.Courses.Where(
                c=> c.CourseId == id).FirstOrDefault(); 
            try
            {
                if (courseToDelete != null)
                {
                    _context.Courses.Remove(courseToDelete);
                    _context.SaveChanges();

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }

        public void DeleteStudent(int id)
        {
            Student studentToDelete = _context.Students.Where(
                c => c.StudentId == id).FirstOrDefault();
            try
            {
                if (studentToDelete != null)
                {
                    _context.Students.Remove(studentToDelete);
                    _context.SaveChanges();

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public Course GetCourse(int id)
        {
            Course course = null;
            try
            {
                course = _context.Courses.FirstOrDefault(c=>c.CourseId == id);
                if(course != null)
                    return course;
            }
             catch(Exception ex) {
                throw new Exception(ex.Message);
            }
            return course;
        }

        public List<Course> GetCourses()
        {
            List<Course> courses = new List<Course>();
            try
            {
                courses = _context.Courses.ToList();
                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return courses;
        }

        public Student GetStudent(int id)
        {
            Student student = null;
            try
            {
                student = _context.Students.FirstOrDefault(c => c.StudentId == id);
                if (student != null)
                    return student;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return student;
        }

        public List<Student> GetStudents()
        {
            List<Student> students = new List<Student>();
            try
            {
                students = _context.Students.ToList();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return students;
        }

        public Course UpdateCourse(Course course)
        {
            Course coursetoupdate = null;
            try
            {
                _context.ChangeTracker.Clear();
                _context.Entry(course).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return course;
        }

        public Student UpdateStudent(Student student)
        {
           
            try
            {
                _context.Entry(student).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return student;
        }
    }
}
