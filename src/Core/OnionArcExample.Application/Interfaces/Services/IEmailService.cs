﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArcExample.Application.Interfaces.Services
{
    public interface IEmailService
    {
        bool Send(string to, string message);
    }
}
