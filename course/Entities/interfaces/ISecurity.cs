using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course.interfaces
{
    internal interface ISecurity : IWorker
    {
        IWeapon Weapon { get; set; }
        ILicenseToCarryWeapon LicenseToCarryWeapon { get; set; }
        ISchedule Schedule { get; set; }
    }
}
