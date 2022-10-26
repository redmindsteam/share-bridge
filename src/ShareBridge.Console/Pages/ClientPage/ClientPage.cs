using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShareBridge.Console.Pages.ClientPage
{
    public class ClientPage
    {
        public static async Task RunAsync()
        {
            System.Console.Clear();
            System.Console.WriteLine("Enter the IP address of the server computer!");
            string Ip = System.Console.ReadLine();
            if (true)
            {
                System.Console.WriteLine("Enter the File Path! ");
                string Path = System.Console.ReadLine();
                System.Console.WriteLine("Please wait!");
                System.Console.WriteLine("Result -> " + "54 % ");
            }
            else 
            {
                System.Console.WriteLine("An error occurred. Enter the correct IP! ");
                System.Console.ReadLine();
                ClientPage.RunAsync();
            }
            
        }
    }
}
