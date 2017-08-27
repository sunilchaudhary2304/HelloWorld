using System;
using System.ServiceModel;
using System.ServiceModel.Activation;
using HelloWorldService.MessageBase;
using Encryption;
using HelloWorldService.Messages;
using HelloWorldService.ServiceContracts;

namespace HelloWorldService.ServiceImplementations
{ /// <summary>
  /// Main facade into Patterns in Action application
  /// </summary>
  /// <remarks>
  /// The Cloud Facade Pattern.
  /// </remarks>
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession)]
   public partial class HelloWorldService:IHelloWorldService
    {
        private string _accessToken;

        private string _userName;

        #region Reference Methods
        //public TameliTypeResponse GetTameliTypes(TameliTypeRequest request)
        //{
        //    TameliTypeResponse response = new TameliTypeResponse();
        //    response.CorrelationId = request.RequestId;

        //    // Validate client tag and access token
        //    //if (!ValidRequest(request, response, Validate.ClientTag | Validate.AccessToken))
        //    //    return response;

        //    List<TameliType> lst = tameliTypeDao.GetTameliTypes();
        //    response.TameliTypes = Mapper.ToDataTransferObjects(lst);
        //    return response;
        //}
        //public CustomerResponse GetCustomers(CustomerRequest request)
        //{
        //    CustomerResponse response = new CustomerResponse();
        //    response.CorrelationId = request.RequestId;

        //    // Validate client tag, access token, and user credentials
        //    if (!ValidRequest(request, response, Validate.All))
        //        return response;

        //    CustomerCriteria criteria = request.Criteria as CustomerCriteria;
        //    string sort = criteria.SortExpression;

        //    if (request.LoadOptions.Contains("Customers"))
        //    {
        //        IEnumerable<Customer> customers;

        //            // Simple customer list without order information
        //            customers = customerDao.GetCustomers(criteria.SortExpression);

        //        response.Customers = customers.Select(c => Mapper.ToDataTransferObject(c)).ToList();
        //    }

        //    if (request.LoadOptions.Contains("Customer"))
        //    {
        //        Customer customer = customerDao.GetCustomer(criteria.CustomerId);               

        //        response.Customer = Mapper.ToDataTransferObject(customer);
        //    }

        //    return response;
        //}
        #endregion

        /// <summary>
        /// Gets unique session based token that is valid for the duration of the session.
        /// </summary>
        /// <param name="request">Token request message.</param>
        /// <returns>Token response message.</returns>
        public TokenResponse GetToken(TokenRequest request)
        {
            TokenResponse response = new TokenResponse();
            response.CorrelationId = request.RequestId;

            // Validate client tag only
            if (!ValidRequest(request, response, Validate.ClientTag))
                return response;

            // Note: these are session based and expire when session expires.
            _accessToken = Guid.NewGuid().ToString();


            response.AccessToken = _accessToken;
            return response;
        }

        #region  Consideration To Be Taken For Future Use
        /// <summary>
        /// Validate 3 security levels for a request: ClientTag, AccessToken, and User Credentials
        /// </summary>
        /// <param name="request">The request message.</param>
        /// <param name="response">The response message.</param>
        /// <param name="validate">The validation that needs to take place.</param>
        /// <returns></returns>
        private bool ValidRequest(RequestBase request, ResponseBase response, Validate validate)
        {
            // Validate Client Tag. In production this should query a 'client' table in a database.
            if ((Validate.ClientTag & validate) == Validate.ClientTag)
            {
                if (request.ClientTag != "ABC123")
                {
                    response.Acknowledge = AcknowledgeType.Failure;
                    response.Message = "Unknown Client Tag";
                    return false;
                }
            }

            // Validate access token
            if ((Validate.AccessToken & validate) == Validate.AccessToken)
            {
                if (_accessToken == null)
                {
                    response.Acknowledge = AcknowledgeType.Failure;
                    response.Message = "Invalid or expired AccessToken. Call GetToken()";
                    return false;
                }
            }

            // Validate user credentials
            if ((Validate.UserCredentials & validate) == Validate.UserCredentials)
            {
                if (_userName == null)
                {
                    response.Acknowledge = AcknowledgeType.Failure;
                    response.Message = "Please login and provide user credentials before accessing these methods.";
                    return false;
                }
            }


            return true;
        }

        #region Used in primary key encryption. Not currently used.

        /// <summary>
        /// Encrypts internal identifier before sending it out to client.
        /// Private helper method.
        /// </summary>
        /// <param name="id">Identifier to be encrypted.</param>
        /// <param name="tableName">Database table in which identifier resides.</param>
        /// <returns>Encrypted stringified identifier.</returns>
        private string EncryptId(int id, string tableName)
        {
            string s = id.ToString() + "|" + tableName;
            return Crypto.ActionEncrypt(s);
        }

        /// <summary>
        /// Decrypts identifiers that come back from client.
        /// Private helper method.
        /// </summary>
        /// <param name="sid">Stringified, encrypted identifier.</param>
        /// <returns>Internal identifier.</returns>
        private int DecryptId(string sid)
        {
            string s = Crypto.ActionDecrypt(sid);
            s = s.Substring(0, s.IndexOf("|"));
            return int.Parse(s);
        }

       

        #endregion

        /// <summary>
        /// Validation options enum. Used in validation of messages.
        /// </summary>
        [Flags]
        private enum Validate
        {
            ClientTag = 0x0001,
            AccessToken = 0x0002,
            UserCredentials = 0x0004,
            All = ClientTag | AccessToken | UserCredentials
        }

        #endregion
    }
}
