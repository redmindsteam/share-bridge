using Newtonsoft.Json;
using ShareBridge.Core.Interfaces;
using ShareBridge.Core.Interfaces.Common;
using ShareBridge.Core.Services;
using ShareBridge.Domain.Models;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ShareBridge.Core.Base
{
    public class FileReceiver : IStartable, IStopable
    {
        private readonly string _host;
        private readonly int _port;
        private readonly TcpListener _listener;
        private readonly IFileService _fileService;

        public FileReceiver(string host, int port)
        {
            _host = host;
            _port = port;
            _listener = new TcpListener(IPAddress.Any, _port);
            _fileService = new FileService();
        }

        public void Start()
        {
            _listener.Start();
            Socket socket = _listener.AcceptSocket();
            int bufferSize = 1024;
            byte[] buffer, header;
            
            header = new byte[bufferSize];
            socket.Receive(header);
            string headerJson = Encoding.ASCII.GetString(header);
            var fileheaders = JsonConvert.DeserializeObject<FileHeaders>(headerJson);

            if (fileheaders is null) throw new Exception("File headers doesn't exist");
            string path = Path.Combine(_fileService.GetResoucePath(), fileheaders.FileName);
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                while (fileheaders.Lenth > 0)
                {
                    buffer = new byte[bufferSize];
                    int size = socket.Receive(buffer, SocketFlags.Partial);
                    fs.Write(buffer, 0, size);
                    fileheaders.Lenth -= size;
                }
                fs.Close();
            }
        }

        public void Stop()
        {
            _listener.Stop();
        }
    }
}