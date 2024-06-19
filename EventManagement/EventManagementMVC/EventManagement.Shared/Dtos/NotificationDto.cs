using EventManagement.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagement.Shared.Dtos
{
    public class NotificationDto : BaseModel
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public string Message { get; set; }
        public DateTime SentTime { get; set; }
        public NotificationType Type { get; set; }
    }
}
