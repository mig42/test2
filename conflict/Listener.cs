using System.Net;

namespace Network
{
    internal class Socket
    {
        internal void Listen()
        {
            // do the listen on a port
            // and whatever it is needed
            // to listen
        }

        internal void ConnectTo(string addr)
        {
            // connect to a remote client
            Net.ConnectTo(addr);
        }

        internal int Recv(byte[] buffer)
        {
            System.IO.Read(buffer);
        }
    }
}
