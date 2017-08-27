using System.Collections.Generic;
using System.Runtime.Serialization;
using HelloWorldService.DataTransferObjects;
using HelloWorldService.MessageBase;

namespace HelloWorldService.Messages
{
    /// <summary>
    /// Represents a TodaysData response message to client
    /// </summary> 
    [DataContract(Namespace = "http://www.test.com/types/")]
    public class TodaysDataResponse : ResponseBase
    {
        [DataMember]
        public TodaysDataDto TodaysData;

        [DataMember]
        public IList<TodaysDataDto> TodaysDatas;
    }
}
