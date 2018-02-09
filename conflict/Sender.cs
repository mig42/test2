using System.Net;

namespace Network
{
    internal class Socket
    {
        internal string GetHostByName(string addr)
        {
            // this method returns the host
            // when you give an IP
            return CalculateHostByName(addr);
        }

        internal int Send(byte[] buffer)
        {
            System.IO.Write(buffer);
        }
    }
}
