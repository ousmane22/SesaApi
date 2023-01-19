using AutoMapper;
using SesaPay.DataModels.Partners;
using SesaPay.Repository.Admin.Interfaces;
using SesaPay.Services.Admin.Interfaces;
using SesaPay.ViewModels.Admin;
using SesaPay.ViewModels.Partner;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SesaPay.Services.Admin.Implementations
{
    public class ManagePrivilegeServices : IManagePrivilegeServices
    {
        private readonly IManagePrivilegeRepository _managePrivilege;
        private readonly IMapper _mapper;
        public ManagePrivilegeServices(IManagePrivilegeRepository managePrivilege, IMapper mapper)
        {
            _managePrivilege = managePrivilege;
            _mapper = mapper;
        }



        public List<City> GetList()
        {
            var cities = _managePrivilege.GetList();
            return _mapper.Map<List<City>>(cities);
        }
    }
}
