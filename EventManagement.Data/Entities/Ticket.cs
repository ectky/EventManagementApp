using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagement.Data.Entities
{
   public class Ticket : BaseEntity
    {
        public int TicketId { get; set; }
        public string Type { get; set; }
        public double Price { get; set; }
    }
}
