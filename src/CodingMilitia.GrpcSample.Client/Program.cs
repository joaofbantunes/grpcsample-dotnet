using System;
using System.Threading.Tasks;
using Grpc.Core;
using CodingMilitia.GrpcSample.Proto.Messages;
using CodingMilitia.GrpcSample.Proto.Service;

namespace CodingMilitia.GrpcSample.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            MainAsync(args).GetAwaiter().GetResult();
        }

        private async static Task MainAsync(string[] args){
            Channel channel = null;            
            try {

                channel = new Channel("127.0.0.1:1234", ChannelCredentials.Insecure);
                var client = new Counter.CounterClient(channel);
                var reply = await client.IncrementAsync(new IncrementRequest{ Requester = "Csharp Tester"});
                Console.WriteLine($"It's the {reply.Count} request the server processed");
            } finally {
                await channel?.ShutdownAsync();
            }
            
        }
    }
}
