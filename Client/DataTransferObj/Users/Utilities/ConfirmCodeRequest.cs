﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.DataTransferObj.Users.Utilities
{
    public class ConfirmCodeRequest
    {
        public Guid ID { get; set; }
        public string? Code { get; set; }
    }
}
