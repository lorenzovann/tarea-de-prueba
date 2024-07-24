using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace liskov.data
{
    public class OnlineCourse : ICourseSubscription
    {
        public int CourseId { get; set; }
        public string Title { get; set; }



        public CourseDetails Details { get; set; } = new CourseDetails();

        public void Subscribe(Student student)
        {
            Console.WriteLine($"{student.Name} ha sido inscrito en el curso online {Title}.");

        }

        public void Subscribe()
        {
            throw new NotImplementedException();
        }
    }
}
