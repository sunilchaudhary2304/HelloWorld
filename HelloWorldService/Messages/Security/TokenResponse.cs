﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Runtime.Serialization;
using HelloWorldService.MessageBase;

namespace HelloWorldService.Messages
{
    /// <summary>
    /// Represents a security token response message from web service to client.
    /// </summary>
    [DataContract(Namespace = "http://www.test.com/types/")]
    public class TokenResponse : ResponseBase
    {
        /// <summary>
        /// Security token returned to the consumer
        /// </summary>
        [DataMember]
        public string AccessToken;
    }
}

