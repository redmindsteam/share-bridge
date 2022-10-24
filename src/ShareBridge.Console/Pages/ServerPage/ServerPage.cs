using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShareBridge.Console.Pages.ServerPage
{
    public class ServerPage
    {
        public static async Task RunAsync()
        {
            System.Console.WriteLine("Server started!");
            string Ip = "192.168.1.1";
            System.Console.WriteLine($"Your IP address {Ip}");
        }
    }
}
