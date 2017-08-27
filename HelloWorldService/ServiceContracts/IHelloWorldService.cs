using System.ServiceModel;

namespace HelloWorldService.ServiceContracts
{
    /// <summary>
    /// IHelloWorldService is the interface for Patterns in Action public services.
    /// </summary>
    /// <remarks>
    /// The Cloud Facade Pattern.
    /// </remarks>


    [ServiceContract(SessionMode = SessionMode.Required)]
    public partial interface IHelloWorldService
    {
    }
}
