using course.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course.Entities.classes
{
    internal class CalculateTotalAmountSingleEvent : ICalculateTotalAmount<ISingleEvent>
    {
        public int CalculateTotalAmount(ISingleEvent eventData) 
        {
            return (int) Math.Ceiling(eventData.Peoples / (double)eventData.EventType_);
        }
    }
}
