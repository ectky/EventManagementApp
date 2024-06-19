using AutoMapper;
using EventManagement.Data.Entities;
using EventManagement.Shared.Dtos;
using Microsoft.AspNetCore.Mvc.Diagnostics;
using Microsoft.Extensions.Logging;
using System.Net.Sockets;

namespace EventManagementMVC
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {

            CreateMap<User, UserDto>();



            CreateMap<Event, EventDto>();



            CreateMap<Participant, ParticipantDto>();



            CreateMap<Ticket, TicketDto>();



            CreateMap<Notification, NotificationDto>();


            CreateMap<Feedback, FeedbackDto>();

        }
    }
}

