using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace liskov.data
{
    public class CourseService
    {
        public void RegisterStudentToCourse(ICourseSubscription substd, Student std)
        {
            substd.Subscribe();
        }
    }
}
