using ShareBridge.Console.Helpers;
using ShareBridge.Core.Base;
using ShareBridge.Core.Interfaces;
using ShareBridge.Core.Services;

namespace ShareBridge.Console.Pages.ServerPage
{
    public class ServerPage
    {
        public static async Task RunAsync()
        {
            IHostService hostService = new HostService();
            string ip = hostService.GetHostIP();

            string promt = $"Enter your IP address on the second computer!\nYour IP address <->  {ip} {hostService.IsConnected("192.168.0.111")}";
            string[] options = {"Listener start", "Homepage", "Exit" }; 
            Menu menu = new Menu(promt, options);
            int selected = menu.Run();
            
            switch (selected)
            {
                case 0: System.Console.Clear();
                        System.Console.WriteLine("Started...");
                        FileReceiver fileReceiver = new FileReceiver(ip, 8000);
                        fileReceiver.Start();
                        System.Console.WriteLine("Successful");
                        
                        break;
                case 1: await MainPage.RunAsyn();
                    break;
                case 2: return;

                default: break;
            }
        }
    }
}
