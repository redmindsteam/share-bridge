using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ShareBridge.Console.Pages
{
    public class MainPage
    {
        public static async Task RunAsyn()
        {
            System.Console.Clear();
            System.Console.WriteLine("1. Server");
            System.Console.WriteLine("2. Client");
            System.Console.WriteLine("3. Exit");

            string selected = System.Console.ReadLine();
            if (selected == "1")
            {
                ServerPage.ServerPage.RunAsync();
            }

            else if (selected == "2")
            {
                ClientPage.ClientPage.RunAsync();
            }

            else
            {
                return;
            }
        }
    }
}
