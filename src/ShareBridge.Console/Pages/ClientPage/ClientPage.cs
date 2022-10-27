using Newtonsoft.Json;
using ShareBridge.Core.Base;
using ShareBridge.Core.Services;
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

            int dotCount = 0;
            bool helper = false;

            foreach (var item in ip)
            {
                if(item == '.' && helper)
                {
                    dotCount++;
                    helper = false;
                }
                if(45 < (int)item && 58 > (int)item)
                {
                    helper = true;
                }
                else
                {
                    dotCount--;
                }
            }

            if (dotCount == 3)
            {
                key:
                FileService fileService = new FileService();
                WriteLine("Please enter the file path!");
                string path = ReadLine()!;
                var item = fileService.GetFileInfo(path);
                if (item.FileName is not null)
                {
                    WriteLine("Sending...");
                    FileSender fileSender = new FileSender(ip, 8000, path);
                    fileSender.Start();
                    WriteLine("Successfully");
                }

                else 
                {
                    WriteLine("Please enter the correct file path!");
                    goto key;
                }
            }
            else 
            {
                WriteLine("An error occurred. Enter the correct IP! \n <<-- Press enter to continue! -->>");
                ReadLine();
                await ClientPage.RunAsync();
            }
        }
    }
}
