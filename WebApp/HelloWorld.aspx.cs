using System;
using WebApp.HelloWorldService;

namespace WebApp
{
    public partial class HelloWorld : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnHelloWorld_Click(object sender, EventArgs e)
        {
          Response.Write(Run());
        }

        public static string Run()
        {
            TodaysDataRequest request = new TodaysDataRequest();
            TodaysDataResponse response = new TodaysDataResponse();
            HelloWorldServiceClient client = new HelloWorldServiceClient();
            response = client.GetTodaysData(request);
            return response.Message;
        }
    }
}