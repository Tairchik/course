using course.Entities.interfaces;
using course.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course.Entities.classes
{
    internal class CalculateTotalAmountMultiEvent : ICalculateTotalAmount<IMultiEvent>
    {
        public int CalculateTotalAmount(IMultiEvent eventData)
        {
            if ((eventData.DateEnd - eventData.DateStart).Days >= 2)
            {
                return (int)Math.Ceiling(eventData.Square / 50 * ((double)eventData.ObjectType_ / 10) * 3);

            }
            else if ((eventData.DateEnd - eventData.DateStart).Days == 1)
            {
                return (int)Math.Ceiling(eventData.Square / 50 * ((double)eventData.ObjectType_ / 10) * 2);
            }
            else
            {
                return (int)Math.Ceiling(eventData.Square / 50 * ((double)eventData.ObjectType_ / 10) * 1);
            }
        }
    }
}
