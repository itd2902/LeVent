﻿// -------------------------------------------------
// Copyright (c) PiorSoft, LLC. All rights reserved.
// -------------------------------------------------

using System.Threading.Tasks;
using System;
using LeVent.Clients;
using LeVent.Tests.Manual.Models.Students;

namespace LeVent.Tests.Manual.Brokers.Events
{
    public partial class EventBroker
    {
        public ILeVentClient<Student> StudentEventClient { get; set; }

        public async ValueTask PublishStudentEventAsync(Student student) =>
            await this.StudentEventClient.PublishEventAsync(student);

        public void RegisterStudentHandler(Func<Student, ValueTask> studentHandler) =>
            this.StudentEventClient.RegisterEventHandler(studentHandler);
    }
}
