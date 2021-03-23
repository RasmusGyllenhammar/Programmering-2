﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternDemo
{
    interface IChannel
    {
        void Subscribe(Subscribers observer);
        void Unsubscribe(Subscribers observer);
        void Notify();
    }
}
