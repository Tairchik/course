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
            return (int)Math.Ceiling(eventData.Square / ((double)eventData.ObjectType_ / 10));
        }
    }
}
