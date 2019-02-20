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
            // get a pi point 
            var point = PIPoint.FindPIPoint(piServer, "PLCW00321500=S20NDD11BU900:XQ008");
            var value = point.CurrentValue();
            var timevalue = value.Timestamp;
            var valuevalue = value.Value;
            
            Console.WriteLine("Tag name: {0} and its Value is: {1}, {2}", point.Name, timevalue, valuevalue);
            piServer.Disconnect();

            Console.ReadKey();
        }
    }
}
