using ShareBridge.Console.Helpers;
using ShareBridge.Core.Base;

namespace ShareBridge.Console.Pages.ServerPage
{
    public class ServerPage
    {
        public static async Task RunAsync()
        {
            string ip = "192.168.0.102";
            string promt = $"Enter your IP address on the second computer!\nYour IP address <->  {ip}";
            FileReceiver fileReceiver = new FileReceiver(ip, 8000);
            fileReceiver.Start();
            string[] options = { "Homepage", "Exit" }; 
            Menu menu = new Menu(promt, options);
            int selected = menu.Run();
            switch (selected)
            {
                case 0: await MainPage.RunAsyn();
                    break;
                case 1: return;

                default: break;
            }

            
        }
    }
}
