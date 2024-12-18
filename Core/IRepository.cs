using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construction_practice_REFORGER.Core
{
    public interface IRepository<T>
    {
        int Add(T item);
        int Remove(T item);
        int GetAll();
    }
}
