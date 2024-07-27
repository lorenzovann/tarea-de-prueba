using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Practica.ISP
{
    public class SimplePrinter : IPrinter
    {
        public string Description { get; set; }
        public string Name { get; set; }
        
        
        public void Print(Document documents)
        {
            Console.WriteLine($" Description for this document {Description}");
            Console.WriteLine($" Name for this document {Name}");
        }
    }
}
