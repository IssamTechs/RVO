﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RVO.Services.Clients.Core.Exceptions
{
    public abstract class DomainException : Exception
    {
        public virtual string Code { get; }

        protected DomainException(string message) : base(message)
        {
        }
    }
}
