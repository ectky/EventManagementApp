using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagement.Data.Entities
{
    public class Venue : BaseEntity
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Capacity { get; set; }

        public ICollection<Event> Events { get; set; }
    }
}
