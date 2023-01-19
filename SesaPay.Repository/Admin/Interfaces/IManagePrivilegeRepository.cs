using SesaPay.DataModels.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SesaPay.Repository.Admin.Interfaces
{
    public interface IManagePrivilegeRepository
    {
        List<tbl_cities> GetList();
    }
}
