using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagement.Data.Entities
{
    public class Notification : BaseEntity
    {
        public int NotificationId { get; set; }
        public string Message { get; set; }
    }
}
