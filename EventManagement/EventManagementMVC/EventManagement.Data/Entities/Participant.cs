using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagement.Data.Entities
{
    public class Participant : BaseEntity
    {
        public int ID { get; set; }
        public int EventID { get; set; }
        public int UserID { get; set; }

        public Event Event { get; set; }
        public User User { get; set; }
    }
}
