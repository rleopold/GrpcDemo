using System;
using Grpc.Core;
using grpc_test;

namespace GreeterClient
{
    class Program
    {
        public static void Main(string[] args)
        {
            Channel channel = new Channel("127.0.0.1:50501", ChannelCredentials.Insecure);

            var client = new TestService.TestServiceClient(channel);

            var reply = client.GetTime(new Request {Body="getting time", Type="time_request"});
            var reply2 = client.SaySomething(new Request {Body="I am saying something", Type="say_something"});

            Console.WriteLine("Greeting: " + reply.Body);   

            channel.ShutdownAsync().Wait();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}