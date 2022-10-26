using ShareBridge.Core.Base;
using static System.Console;

namespace ShareBridge.Console.Pages.ClientPage
{
    public class ClientPage
    {
        public static async Task RunAsync()
        {
            Clear();
            WriteLine("Enter the IP address of the server computer!");
            string ip = ReadLine()!;
            if (true)
            {
                WriteLine("Please enter the file path!");
                string path = ReadLine()!;
                WriteLine("Sending...");
                FileSender fileSender = new FileSender(ip, 8000, path);
                fileSender.Start();
                WriteLine("Successfully");
            }
            else 
            {
                WriteLine("An error occurred. Enter the correct IP!");
                ReadLine();
                await ClientPage.RunAsync();
            }
        }
    }
}
