using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace liskov.data
{
    public interface ICourseSubscription
    {
        public int CourseId { get; set; }
        public string Title { get; set; }
        
        
        public void Subscribe();
    }
}
