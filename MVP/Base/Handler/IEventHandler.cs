﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP.Base.Handler
{
    public interface IEventHandler<T> where T : Base.Event.Event
    {
        Task Handle(T evento);
    }
}
