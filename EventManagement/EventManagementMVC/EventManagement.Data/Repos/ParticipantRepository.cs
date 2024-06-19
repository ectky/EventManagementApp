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
    internal class ParticipantRepository : BaseRepository<Participant, ParticipantDto>, IParticipantRepository
    {
        public ParticipantRepository(EventManagementContext context, IMapper mapper) : base(context, mapper)
        {


        }
    }
}
