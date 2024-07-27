using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.ISP
{
    public interface IMultiPrinter
    {
        void print(Document documents);
        void Scan(Document documents);
    }
}
