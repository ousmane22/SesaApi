using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SesaPay.DataModels
{
    public interface IEntityBase
    {
         int Id { get; set; }
         DateTime CreatedAt { get; set; }
         DateTime UpdatedAt { get; set; }
         DateTime DeleteAt { get; set; }
    }
}
