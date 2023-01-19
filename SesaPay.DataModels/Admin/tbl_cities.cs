using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SesaPay.DataModels.Admin
{
    [Table("tbl_cities")]
    public class tbl_cities
    {
        [Key]
        [Column("city_id")]
        public int city_id { get; set; }
        [Column("city_name")]
        public string city_name { get; set; }
        [Column("state_id")]
        public int state_id { get; set; }
        [Column("country_id")]
        public int country_id { get; set; }
    }
}
