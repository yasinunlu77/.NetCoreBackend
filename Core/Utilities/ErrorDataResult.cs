﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities
{
    public class ErrorDataResult<T> : DataResult<T>
    {
        public ErrorDataResult(T Data, string message) : base(Data, false, message)
        {
        }
        public ErrorDataResult(T Data) : base(Data, false)
        {
        }
        public ErrorDataResult(string message) : base(default, false, message)
        {
        }
        public ErrorDataResult() : base(default, false)
        {
        }
    }
}
