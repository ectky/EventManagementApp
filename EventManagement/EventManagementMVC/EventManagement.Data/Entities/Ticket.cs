﻿using EventManagement.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagement.Data.Entities
{
    public class Ticket : BaseEntity
    {
        public int ID { get; set; }
        public int EventID { get; set; }
        public int ParticipantID { get; set; }
        public decimal Price { get; set; }
        public TicketType Type { get; set; }

        public Event Event { get; set; }
        public Participant Participant { get; set; }
    }
}
