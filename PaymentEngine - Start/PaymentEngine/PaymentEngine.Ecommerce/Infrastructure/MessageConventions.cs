﻿//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by ServiceMatrix.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NServiceBus;

namespace PaymentEngine.Ecommerce
{
    public class MessageConventions : IWantToRunBeforeConfiguration
    {
        public void Init()
        {
            Configure.Instance
            .DefiningCommandsAs(t => t.Namespace != null && t.Namespace.StartsWith("PaymentEngine.Internal.Commands"))
            .DefiningEventsAs(t => t.Namespace != null && t.Namespace.StartsWith("PaymentEngine.Contracts"))
            .DefiningMessagesAs(t => t.Namespace != null && t.Namespace.StartsWith("PaymentEngine.Internal.Messages"));
        }
    }
}

