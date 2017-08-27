using System.Runtime.Serialization;

namespace HelloWorldService.MessageBase
{
    /// <summary>
    /// Enumeration of message response acknowledgements. This is a simple
    /// enumerated values indicating success of failure.
    /// </summary>
    [DataContract(Namespace = "http://www.test.com/types/")]
    public enum AcknowledgeType
    {
        /// <summary>
        /// Respresents an failed response.
        /// </summary>
        [EnumMember]
        Failure = 0,

        /// <summary>
        /// Represents a successful response.
        /// </summary>
        [EnumMember]
        Success = 1
    }
}