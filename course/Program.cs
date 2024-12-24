using course.Entities.classes;
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
            
            IAddress address = new AddressRU("Russia", "Новосибирская область", "Новосибирск", "Тюленина", "дом 28");

            DateTime dateStart = new DateTime(2024, 12, 24, 10, 0, 0);
            DateTime dateEnd = new DateTime(2024, 12, 24, 15, 0 , 0);

            Console.WriteLine(dateStart.CompareTo(dateEnd));
            IEvent _event = new SingleEvent(address, dateStart, dateEnd, EventType.Public, 200);

   
        }
    }
}
