﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACX.Application.Exceptions
{
    public class BadRequest:Exception
    {
        public BadRequest(string message): base(message)
        {
            
        }
    }
}
