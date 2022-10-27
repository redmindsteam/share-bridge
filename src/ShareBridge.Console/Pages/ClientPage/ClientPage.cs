using Newtonsoft.Json;
using ShareBridge.Core.Base;
using ShareBridge.Core.Interfaces;
using ShareBridge.Core.Services;
using ShareBridge.Core.Validators;
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

            if (IpAddressValidator.IsValid(ip))
            {
                IHostService hostService = new HostService();
                if (hostService.IsConnected(ip))
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
                    WriteLine($"{ip} is disconnect!");
                    Thread.Sleep(3000);
                    await RunAsync();
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
