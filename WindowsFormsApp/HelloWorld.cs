using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp.HelloWorldService;

namespace WindowsFormsApp
{
    public partial class HelloWorld : Form
    {
        public HelloWorld()
        {
            InitializeComponent();
        }

        private void btnHelloWorld_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Run(),"Hello App");
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
