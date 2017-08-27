using System;
using ConsoleApp.HelloWorldService;

namespace ConsoleApp
{
  public class MainDriver
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Run());
            Console.ReadKey(); 
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
