

namespace Cursos.Common
{
    public class OnlineCourse : ICoursesSubscription
    {
        public int CourseId { get; set; }
        public string Title { get; set; }




        public void Subscribe(Student std)
        {
            Console.WriteLine(value: $"Se ha inscrito al curso virtual {Title}");
        }

    }
}