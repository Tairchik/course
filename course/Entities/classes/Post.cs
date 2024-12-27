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
        private int salary;

        public Post(string _namePost, int _salary) 
        {
            NamePost = _namePost;
            Salary = _salary;
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
        public int Salary
        {
            get  { return salary; }
            set
            {
                if (value < 0)
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
