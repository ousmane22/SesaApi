using SesaPay.DataModels.Partners;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SesaPay.Repository
{
    public interface IRepositoryBase<T>
    {
        IEnumerable<T> GetAll();
        tbl_partner Get(int id );

        void Delete(int t);
        void Create(T t);
        void UpdateT(T t);
    }
}
