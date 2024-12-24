using course.Entities.classes;
using course.Entities.interfaces;
using course.interfaces;
using course.YourProjectNamespace.Common;
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

            DateTime dateStart = new DateTime(2024, 12, 24);
            DateTime dateEnd = new DateTime(2024, 12, 24);

            Console.WriteLine((dateEnd - dateStart).Days);

            Console.WriteLine(dateStart.CompareTo(dateEnd));
            ISingleEvent _event = new SingleEvent(address, dateStart, dateEnd, EventType.Public, 250, new CalculateTotalAmountSingleEvent());
            IMultiEvent mEvent = new MultiEvent(address, dateStart, dateEnd, ObjectType.Commercial, 25, new CalculateTotalAmountMultiEvent());

            
            Console.WriteLine(_event.CalculateAmount());
            Console.WriteLine(mEvent.CalculateAmount());
        }
    }
}
