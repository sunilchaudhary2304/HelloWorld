using System;
using BusinessObjects.TodaysData;
using DataObjects;
using DataObjects.Interfaces;
using HelloWorldService.MessageBase;
using HelloWorldService.Messages;
using HelloWorldService.ServiceContracts;
using static HelloWorldService.DataTransferObjectMapper.TodaysDataMapper;

namespace HelloWorldService.ServiceImplementations
{
    /// <summary>
    /// Main facade into Patterns in Action application
    /// </summary>
    /// <remarks>
    /// The Cloud Facade Pattern.
    /// </remarks>
    public partial class HelloWorldService:IHelloWorldService
    {
        private static ITodaysDataDao todaysDataDao = DataAccess.TodaysDataDao;

        
        public TodaysDataResponse GetTodaysData(TodaysDataRequest request)
        {
            TodaysDataResponse response = new TodaysDataResponse();
            TodaysData objTD = new TodaysData();
            try
            {
                objTD = Mapper.FromDataTransferObject(request.TodaysData);

                response.Message = todaysDataDao.GetTodaysData();
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;

                response.Acknowledge = AcknowledgeType.Failure;
            }

            return response;
        }
    }
}
