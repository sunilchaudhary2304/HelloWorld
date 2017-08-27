using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Runtime.Serialization;
using HelloWorldService.MessageBase;

namespace HelloWorldService.Messages
{
    /// <summary>
    /// Respresents a security token request message from client to web service.
    /// </summary>
    [DataContract(Namespace = "http://www.test.com/types/")]
    public class TokenRequest : RequestBase
    {
        // Nothing needed here...
    }
}

