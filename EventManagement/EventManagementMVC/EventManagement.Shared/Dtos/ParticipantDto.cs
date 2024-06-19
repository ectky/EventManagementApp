using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagement.Shared.Dtos
{
    public class ParticipantDto : BaseModel
    {
        public int ID { get; set; }
        public int EventID { get; set; }
        public int UserID { get; set; }
    }
}
