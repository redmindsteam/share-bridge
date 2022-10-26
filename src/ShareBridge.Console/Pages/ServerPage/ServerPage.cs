using Demo;

namespace ShareBridge.Console.Pages.ServerPage
{
    public class ServerPage
    {
        public static async Task RunAsync()
        {
            string Ip = "192.168.1.1";
            string promt = $"Enter your IP address on the second computer!\nYour IP address <->  {Ip}";
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
