﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities
{
    public class Result : IResult
    {
        public bool success { get; }
        public string Message { get; }

        public Result(bool success, string message) : this(success)
        {
            Message = message;
        }

        public Result(bool success)
        {
            this.success = success;
        }

    }
}
