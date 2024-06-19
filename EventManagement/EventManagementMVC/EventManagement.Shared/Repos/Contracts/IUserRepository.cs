﻿using EventManagement.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagement.Shared.Repos.Contracts
{
    public interface IUserRepository: IBaseRepository<UserDto>
    {
    }
}
