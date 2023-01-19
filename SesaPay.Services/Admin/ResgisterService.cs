using Microsoft.Extensions.DependencyInjection;
using SesaPay.Services.Admin.Implementations;
using SesaPay.Services.Admin.Interfaces;
using SesaPay.Services.Partner.Implementations;
using SesaPay.Services.Partner.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SesaPay.Services.Admin
{
    public static class RegisterService
    {
        public static IServiceCollection AddAdminServices(this IServiceCollection services)
        {
            services.AddTransient<IManagePrivilegeServices, ManagePrivilegeServices>();
            services.AddTransient<IPartnerService, PartnerService>();
            return services;
        }
    }
}
