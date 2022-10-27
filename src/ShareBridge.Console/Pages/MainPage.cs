using ShareBridge.Console.Helpers;
using static System.Console;

namespace ShareBridge.Console.Pages
{
    public class MainPage
    {
        public static async Task RunAsyn()
        {
            Clear();
            string prompt = "Select the desired section!";
            string[] options = {"Server", "Client", "Exit"};
            var menu = new Menu(prompt, options);
            int selected = menu.Run();

            switch (selected)
            {
                case 0: await ServerPage.ServerPage.RunAsync();
                    break;
                case 1: await ClientPage.ClientPage.RunAsync();
                    break;
                case 2: return;
                    
                default:
                    break;
            }
        }
    }
}
