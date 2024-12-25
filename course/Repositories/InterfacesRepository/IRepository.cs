using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course.Repositories.InterfacesRepository
{
    internal interface IRepository<T, IDType>
    {
        void Add(T item);
        bool Remove(T item);
        void Update(T item);
        T GetById(IDType id);
        List<T> GetAll();
    }
}
