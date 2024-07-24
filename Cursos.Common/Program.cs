

namespace Cursos.Common
{
    public class Program
    {
        static void Main(string[] args)
        { 
            var offlineCourse = new OfflineCourse { CourseId = 1, Title = "Curso Presencial" };
            var onlineCourse = new OnlineCourse { CourseId = 2, Title = "Curso Virtual" };

            var student = new Student {Name = "Jose" };

            var courseService = new CourseServices();


            courseService.RegisterStudentToCourse(offlineCourse, student);
            courseService.RegisterStudentToCourse(onlineCourse, student);



        }
    }
}
