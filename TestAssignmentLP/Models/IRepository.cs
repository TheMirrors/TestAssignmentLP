using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAssignmentLP.Models
{
    interface IRepository<T>
        where T : class
    {
        void Create(T item);
        void Update(T item);
        void Delete(int id);
        T Find(int id);
        IEnumerable<T> ReadAll(); 
    }
}
