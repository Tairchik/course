using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course.interfaces
{
    internal interface IContract
    {
        string ContractNumber { get;}
        DateTime DateStart { get; set; }
        DateTime DateEnd { get; set; }
        IEvent Event { get; set; }
       
        IContractPayment ContractPayment { get;} 
        
    }
}
