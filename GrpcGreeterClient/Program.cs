using System.Threading.Tasks;
using Grpc.Net.Client;
using GrpcGreeterClient;

// The port number must match the port of the gRPC server.
using var channel = GrpcChannel.ForAddress("https://localhost:7241");

Greeter.GreeterClient client = new Greeter.GreeterClient(channel);
HelloReply reply = await client.SayHelloAsync(new HelloRequest { Name = "GreeterClient" });

Console.WriteLine("Greeting: " + reply.Message);

HelloReply dateReply = await client.SayCurrentDateAsync(new HelloRequest { Name = "GreeterClient"});

Console.WriteLine("SayCurrentDate: " + dateReply.Message);

Console.WriteLine("Press any key to exit...");
Console.ReadKey();