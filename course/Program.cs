using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Post maneger = new Post() {namePost = "менеджер", salary = 12000};
            maneger.salary = 15000;
            Worker w = new Worker("Иванов");
            Worker a = new Worker("Petr", maneger);

        }
        public class Worker
        {
            private string fio;
            private Post post;

            public string FIO 
            {
                get { return fio;}
                set { fio = value; }
            }
            public Worker(string fio, Post post)
            {
                this.post = post;
                FIO = fio;
            }
            public Worker(string fio)
            {
                FIO = fio;
            }
        }
        public class Post
        {
            public string namePost { get; set; }
            public int salary { get; set; }

           
        }
    }
}
