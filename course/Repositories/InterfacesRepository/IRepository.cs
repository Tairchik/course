using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course.Repositories.InterfacesRepository
{
    internal interface IRepository<T>
    {
        void Add(T item);
        bool Remove(T item);
        void Update(T item);
        T GetById(string id);
        IEnumerable<T> GetAll();
    }
}
