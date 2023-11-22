using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Persistence
{
    public interface IRepository<T>
    {
        void Append(T contact);
        T[] GetAll();
        T Get(int id);
        void Update(int id, T contact);
        void Remove(int id);

    }
}
