using System.Net;

namespace Network
{
    internal class Socket
    {
        internal void ConnectTo(string addr)
        {
            // connect to a client
            Net.ConnectTo(addr);
        }

        internal int Send(byte[] buffer)
        {
            System.IO.Write(buffer);
        }
    }
}
