

namespace Cursos.Common
{
    public class CourseServices
    {
        public void RegisterStudentToCourse(ICoursesSubscription substd, Student std)
        {
            substd.Subscribe(std);

        }
    }
}
