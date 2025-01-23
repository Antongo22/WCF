using System;
using System.ServiceModel;
using WcfServiceLibrary1;

namespace User
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BasicHttpBinding binding = new BasicHttpBinding();
            EndpointAddress address = new EndpointAddress("http://localhost:8212/MyService");

            ChannelFactory<IService1> factory = new ChannelFactory<IService1>(binding, address);
            IService1 channel = factory.CreateChannel();

            string response = channel.GetData(42);
            Console.WriteLine("Response: {0}", response);

            ((ICommunicationObject)channel).Close();

            Console.WriteLine("Press <Enter> to exit.");
            Console.ReadLine();
        }
    }
}