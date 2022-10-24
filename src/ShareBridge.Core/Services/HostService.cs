using ShareBridge.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ShareBridge.Core.Services
{
    public class HostService : IHostService
    {
        public async Task<string> GetHostName()
        {
            string hostName = Dns.GetHostName(); // Retrive the Name of HOST
            // Get the IP
            string myIP = Dns.GetHostByName(hostName).AddressList[1].ToString();
            return myIP;
        }
    }
}
