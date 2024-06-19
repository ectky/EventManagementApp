using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagement.Shared.Dtos
{
    public class FeedbackDto : BaseModel
    {
        public int ID { get; set; }
        public int EventID { get; set; }
        public int UserID { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
    }

    
}
