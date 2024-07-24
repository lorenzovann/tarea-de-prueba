

namespace Cursos.Common
{
    public class OfflineCourse : ICoursesSubscription
    {
        public int CourseId { get; set; }
        public string Title { get; set; }

        public void Subscribe(Student std)
        {
            Console.WriteLine($"Ha sido inscrito en el curso presencial {Title}");
        }
    }
}
