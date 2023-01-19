using Microsoft.Extensions.DependencyInjection;
using SesaPay.Repository.Admin.Implementations;
using SesaPay.Repository.Admin.Interfaces;
using SesaPay.Repository.Partner.Implementation;
using SesaPay.Repository.Partner.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SesaPay.Repository.Admin
{
    public static class RegisterRepository
    {
        public static IServiceCollection AddAdminRepository(this IServiceCollection services)
        {
            services.AddTransient<IManagePrivilegeRepository, ManagePrivilegeRepository>();
            services.AddTransient<IPartnerRepository, PartnerRepository>();
            return services;
        }
    }
}
