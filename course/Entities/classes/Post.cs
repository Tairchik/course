using course.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course.Entities.classes
{
    internal class Post : IPost
    {
        private string namePost;
        private decimal salary;

        public Post(string namePost, decimal salary) 
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
        public override string ToString()
        {
            return $"{namePost} {salary}";
        }
        public decimal Salary
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
