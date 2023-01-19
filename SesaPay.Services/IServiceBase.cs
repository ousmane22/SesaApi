using SesaPay.DataModels.Partners;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SesaPay.Services
{
    public interface IServiceBase<T>
    {
        List<T> GetAlls();
        T Get(int id);
        void Delete(int t);
        void Created(T t);
        void UpdateTT(T t);
    }
}
