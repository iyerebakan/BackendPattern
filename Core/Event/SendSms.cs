﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Event;

namespace Core.Event
{
    public class SendSms : IEvent
    {
        public void Execute()
        {
            Console.WriteLine("sms send");
        }
    }
}