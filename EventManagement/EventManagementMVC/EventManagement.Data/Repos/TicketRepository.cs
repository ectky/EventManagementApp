using AutoMapper;
using EventManagement.Data.Entities;
using EventManagement.Shared.Dtos;
using EventManagement.Shared.Repos.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagement.Data.Repos
{
    public class TicketRepository : BaseRepository<Ticket, TicketDto>, ITicketRepository
    {
        public TicketRepository(EventManagementContext context, IMapper mapper) : base(context, mapper)
        {


        }
    }
}
