using SesaPay.DataModels.Partners;
using SesaPay.ViewModels.Admin;
using SesaPay.ViewModels.Partner;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SesaPay.Services.Admin.Interfaces
{
    public interface IManagePrivilegeServices
    {
        List<City> GetList();
       
    }
}
