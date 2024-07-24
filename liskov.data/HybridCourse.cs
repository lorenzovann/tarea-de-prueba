using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace liskov.data
{
    public class HybridCourse : ICourseSubscription
    {
        

        public CourseDetails Details { get; set; } = new CourseDetails();
        public int CourseId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Title { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Subscribe(Student student)
        {
            
            Console.WriteLine($"{student.Name} ha sido inscrito en el curso híbrido {Title}.");
        }

        public void Subscribe()
        {
            throw new NotImplementedException();
        }
    }
}
