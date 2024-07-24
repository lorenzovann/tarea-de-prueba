using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace liskov.data
{
    public class Program
    {
        static void Main(string[] args)
        {
            var onlineCourse = new OnlineCourse { Details = { CourseId = 1, Title = "Curso en Línea " } };
            var offlineCourse = new OfflineCourse { Details = { CourseId = 2, Title = "Curso Presencial " } };
            var hybridCourse = new HybridCourse { Details = { CourseId = 3, Title = "Curso Híbrido " } };

            var student = new Student { Name = "Juan Pérez" };

            var courseService = new CourseService();

            // Registro de estudiantes en diferentes tipos de cursos
            courseService.RegisterStudentToCourse(onlineCourse, student);
            courseService.RegisterStudentToCourse(offlineCourse, student);
            courseService.RegisterStudentToCourse(hybridCourse, student);
        }
    }
}
