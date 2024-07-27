using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.ISP
{
    public class MultiFunctionPrinter : IMultiPrinter
    {
        public string Description { get; set; }
        public string Name { get; set; }

        public void print(Document documents)
        {
            Console.WriteLine($" Description for this document {Description}");
            Console.WriteLine($" Name for this document {Name}");

        }

        public void Scan(Document documents)
        {
            Console.WriteLine($" Description for this document {Description}");
            Console.WriteLine($" Name for this document {Name}");

        }
    }
}
