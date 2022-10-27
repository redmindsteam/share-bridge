using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShareBridge.Core.Interfaces
{
    public interface IHostService
    {
        string GetHostIP();

        bool IsConnected(string ip);
    }
}
