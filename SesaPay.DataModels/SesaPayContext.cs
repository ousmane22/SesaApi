using Microsoft.EntityFrameworkCore;
using SesaPay.DataModels.Admin;
using SesaPay.DataModels.Partners;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SesaPay.DataModels
{
    public class SesaPayContext : DbContext
    {
        public SesaPayContext(DbContextOptions<SesaPayContext> options) : base(options)
        {
        }
        public DbSet<tbl_cities>  tbl_Cities { get; set; }
        public DbSet<tbl_partner>  tbl_Partners { get; set; }

    }
}
