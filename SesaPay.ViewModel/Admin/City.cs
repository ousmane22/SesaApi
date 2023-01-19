using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SesaPay.ViewModels.Admin
{
    public class City
    {
        public int city_id { get; set; }
        public string city_name { get; set; }
        public int state_id { get; set; }
        public int country_id { get; set; }
    }
}
