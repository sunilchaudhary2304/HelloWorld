using System.Windows;
using WPFApp.HelloWorldService;

namespace WPFApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void HelloWorld_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(Run(), "My App");
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
