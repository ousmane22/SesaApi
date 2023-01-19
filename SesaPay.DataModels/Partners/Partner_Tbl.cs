using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace SesaPay.DataModels.Partners
{
    [Table("tbl_partners")]
    public class Partner_Tbl:IEntityBase
    {
        [Key]
        [Column("partner_id")]
        public int Id { get; set; }

        [Column("partner_name")]
        public string? PartnerName { get; set; }

        [Column("partner_operator")]
        public string? PartnerOperator  { get; set; }

        [Column("partner_email")]
        public string? PartnerEmail { get; set; }

        [Column("partner_phone_code")]
        public int PhoneCode { get; set; }

        [Column("partner_mobile_number")]
        public int MobileNumber { get; set; }

        [Column("partner_password")]
        public string? Password { get; set; }

        [Column("created_at")]
        public DateTime CreatedAt { get; set; }

        [Column("updated_at")]
        public DateTime UpdatedAt { get; set; }

        [Column("delete_at")]
        public DateTime DeleteAt { get; set; }
    }
}
