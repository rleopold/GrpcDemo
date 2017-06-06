using System;
using Grpc.Core;
using grpc_test;

namespace grpc_test
{
    class Program
    {
        static void Main(string[] args)
        {
            const int port = 50501;
            Server server = new Server
            {
                Services = { TestService.BindService(new TestServer()) },
                Ports = { new ServerPort("localhost", port, ServerCredentials.Insecure) }
            };
            server.Start();

            Console.WriteLine("Greeter server listening on port " + port);
            Console.WriteLine("Press any key to stop the server...");
            Console.ReadKey();

            server.ShutdownAsync().Wait();
        }
    }
}