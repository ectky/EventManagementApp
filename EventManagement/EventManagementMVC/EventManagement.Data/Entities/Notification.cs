using EventManagement.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagement.Data.Entities
{
    public class Notification : BaseEntity
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public string Message { get; set; }
        public DateTime SentTime { get; set; }
        public NotificationType Type { get; set; }

        public User User { get; set; }
    }
}
