using System.ServiceModel;
using HelloWorldService.Messages;
namespace HelloWorldService.ServiceContracts
{
    /// <summary>
    /// IHelloWorldService is the interface for Patterns in Action public services.
    /// </summary>
    /// <remarks>
    /// The Cloud Facade Pattern.
    /// </remarks>
    public partial interface IHelloWorldService
    {
        [OperationContract]

        TodaysDataResponse GetTodaysData(TodaysDataRequest request);

    }
}
