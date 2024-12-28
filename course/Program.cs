using course.Entities.classes;
using course;
using course.interfaces;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using course.Forms;
using Newtonsoft.Json;
using System.Diagnostics.Contracts;
using System.IO;
using course.Repositories.ClassRepository;
using course.Repositories.InterfacesRepository;

namespace course
{
    internal class Program
    {
        static void Main()
        {
          

          Application.EnableVisualStyles();
          Application.SetCompatibleTextRenderingDefault(false);
          Application.Run(new ManagerForm());
        }
    }
}
