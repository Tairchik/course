using course.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course
{
    internal class Post : IPost
    {
        private string namePost;
        private Decimal salary;

        public Post(string namePost, Decimal salary) 
        {
            NamePost = namePost;
            Salary = salary;
        }
        public string NamePost
        {
            get { return namePost; }
            set
            {
                namePost = value;
            }
        }
        public Decimal Salary
        {
            get  { return salary; }
            set
            {
                if (salary.CompareTo(0m) < 0)
                {
                    throw new ArgumentException("Неверный оклад");
                }
                else
                {
                    salary = value;
                }
            }
        }
    }
}
