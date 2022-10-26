using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ShareBridge.Console.Pages.ClientPage
{
    public class ClientPage
    {
        public static async Task RunAsync()
        {
            Clear();
            WriteLine("Enter the IP address of the server computer!");
            string Ip = ReadLine()!;
            if (true)
            {
                WriteLine("Enter the File Path! ");
                string Path = ReadLine()!;
                WriteLine("Please wait!");
                WriteLine("Result -> " + "54 % ");
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
