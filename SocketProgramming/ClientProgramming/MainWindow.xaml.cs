using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Net;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ClientProgramming
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

   

    public partial class MainWindow : Window
    {
        Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);        

        public MainWindow()
        {
            InitializeComponent();
            //socket.Connect("localhost", 8080);
            IPEndPoint endPoint = new IPEndPoint(Dns.GetHostEntry("localhost").AddressList[0], 8080);
            socket.Connect(endPoint);

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            string x = sendingMsg.Text;
            
            socket.Send(Encoding.ASCII.GetBytes(x));

            msg.Text += "You: " + x + Environment.NewLine;
            sendingMsg.Text = null;
        }
    }
}
