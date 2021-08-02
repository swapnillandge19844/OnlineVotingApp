﻿using OnlineVotingApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineVotingApp.Services
{
    public interface IAuthenticateService
    {
        User Authenticate(string userName, string password);
    }
}
