using ShareBridge.Core.Base;

class Program
{
    public static void Main()
    {
        string host = "192.168.0.102";
        FileReceiver fileReceiver = new FileReceiver(host, 8000);
        fileReceiver.Start();
    }
}
