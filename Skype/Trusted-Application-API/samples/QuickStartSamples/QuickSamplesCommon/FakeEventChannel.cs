﻿using Microsoft.SfB.PlatformService.SDK.ClientModel;
using System;
using System.Threading.Tasks;

namespace QuickSamplesCommon
{
    /// <summary>
    /// Fake event channel used in samples where call back is not required
    /// Like remote advisor sample
    /// </summary>
    public class FakeEventChannel : IEventChannel
    {
        public event EventHandler<EventsChannelArgs> HandleIncomingEvents;

        public Task TryStartAsync()
        {
            return Task.CompletedTask;
        }

        public Task TryStopAsync()
        {
            return Task.CompletedTask;
        }
    }
}
