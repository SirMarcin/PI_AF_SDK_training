using OSIsoft.AF.PI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFSDKDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            PIServers pIServers = new PIServers();
            foreach(var server in pIServers)
            {
                Console.WriteLine("Server: {0}", server.Name);
            }

            PIServer piServer = pIServers.DefaultPIServer;
            Console.WriteLine("Default connection is: {0}", piServer.Name);

            piServer.Connect();

            // do smth with the pi system

            piServer.Disconnect();

            Console.ReadKey();
        }
    }
}
