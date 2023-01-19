using AutoMapper;
using SesaPay.DataModels.Admin;
using SesaPay.DataModels.Partners;
using SesaPay.ViewModels.Admin;
using SesaPay.ViewModels.Partner;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SesaPay.DataModels
{
    public class MapperProfile:Profile
    {
        public MapperProfile()
        {
            CreateMap<tbl_cities, City>();
            CreateMap<tbl_partner, PartnerModel>();
        }
    }
}
