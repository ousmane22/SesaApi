using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SesaPay.DataModels.Adherent
{
    [Table("tbl_adherents")]
    public class Partner:IEntityBase
    {
        [Column("adherent_id")]

        public int Id { get; set; }

        [Column("first_name")]
        public string? FirstName { get; set; }

        [Column("last_name")]
        public string? LastName { get; set; }

        [Column("phone_number")]
        public int  PhoneNumber { get; set; }

        [Column("number_fixe")]
        public int Fixe { get; set; }

        [Column("created_at")]
        public DateTime CreatedAt { get; set; }

        [Column("updated_at")]
        public DateTime UpdatedAt { get; set; }

        [Column("delete_at")]
        public DateTime DeleteAt { get; set; }
    }
}
