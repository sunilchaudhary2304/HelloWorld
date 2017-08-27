using System.Runtime.Serialization;

namespace HelloWorldService.DataTransferObjects
{
    /// <summary>
    /// TodaysData Data Transfer Object.
    /// 
    /// The purpose of the TodaysDataTransferObject is to facilitate transport of 
    /// Application business data in a serializable format. Business data is kept in 
    /// publicly accessible auto properties. This class has no methods. 
    /// </summary>
    /// <remarks>
    /// Pattern: Data Transfer Objects.
    /// 
    /// Data Transfer Objects are objects that transfer data between processes, but without behavior.
    /// </remarks>
    [DataContract(Name = "TodaysData", Namespace = "http://www.test.com.np/types/")]
    public class TodaysDataDto
    {
        [DataMember]
        public string Data { get; set; }
    }
}
