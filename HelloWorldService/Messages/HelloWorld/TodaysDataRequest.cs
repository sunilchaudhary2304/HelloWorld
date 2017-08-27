using System.Collections.Generic;
using System.Runtime.Serialization;
using HelloWorldService.DataTransferObjects;
using HelloWorldService.MessageBase;

namespace HelloWorldService.Messages
{
    /// <summary>
    /// Represents a TodaysData request message from client.
    /// </summary>
    [DataContract(Namespace = "http://www.test.com/types/")]
    public  class TodaysDataRequest:RequestBase
    {
        [DataMember]
        public TodaysDataDto TodaysData;

        [DataMember]
        public List<TodaysDataDto> TodaysDatas;

        [DataMember]
        public string Data;
    }
}
