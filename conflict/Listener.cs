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

        internal string GetHostByName(string addr)
        {
            // this method shouldn't be here but returns the host
            // when you give an IP
            return CalculateHostByName(addr) + ";";
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
