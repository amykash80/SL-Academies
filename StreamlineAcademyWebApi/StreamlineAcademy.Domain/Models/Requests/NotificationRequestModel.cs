﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamlineAcademy.Domain.Models.Requests
{
    public class NotificationRequestModel
    {
        public string? Subject { get; set; }
        public string? Body { get; set; }
    }
}
