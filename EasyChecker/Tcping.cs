using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace EasyChecker
{
    class Tcping
    {
        public static List<int> Ping(string ip,int port)
        {
            var times = new List<int>();
            for (int i = 0; i < 4; i++)
            {
                Socket socks = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
                {
                    Blocking = true
                };

                IPEndPoint point;
                try
                {
                    point = new IPEndPoint(IPAddress.Parse(ip), port);
                }
                catch
                {
                    point = new IPEndPoint(Dns.GetHostAddresses(ip)[0], port);
                }


                Stopwatch stopWatch = new Stopwatch();

                stopWatch.Start();
                socks.Connect(point);
                stopWatch.Stop();

                double time = stopWatch.Elapsed.TotalMilliseconds;
                times.Add(Convert.ToInt32(time));
                socks.Close();

                Thread.Sleep(100);
            }

            return times;
        }
    }
}
