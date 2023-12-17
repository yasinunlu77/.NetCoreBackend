﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities
{
    public class DataResult<T> : Result, IDataResult<T>
    {
        public T Data { get; }

        public DataResult(T Data,bool success,string message):base(success,message)
        {
            this.Data = Data;
        }
        public DataResult(T Data,bool success) : base(success)
        {
            this.Data = Data;
        }

    }
}
