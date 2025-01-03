﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course.interfaces
{
    internal interface IWorker : IPerson
    {
        string Name { get; set; }
        string Surname { get; set; }
        string Patronymic { get; set; }
        IPost PostData  { get; set; }
        Decimal BonusSalary { get; set; }
        ITransport TransportData { get; set; }
        IPassport PassportData { get; set; }
        IINN INNData { get; set; }
        IPensionFund PensionFundData { get; set; }

    }
}
