using course.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ITransport transport = new TransportRU("1234ав 222", "Niva");
            Console.Write(transport.RegisterNumber);
        }
    }
}
