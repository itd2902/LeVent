﻿// -------------------------------------------------
// Copyright (c) PiorSoft, LLC. All rights reserved.
// -------------------------------------------------

using System;
using System.Threading.Tasks;

namespace LeVent.Clients
{
    public interface ILeVentClient<T>
    {
        void RegisterEventHandler(Func<T, ValueTask> eventHandler);
        ValueTask PublishEventAsync(T @event);
    }
}
