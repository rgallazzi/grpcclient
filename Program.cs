using System.Threading.Tasks;
using Grpc.Net.Client;
using GrpcGreeterClient;

try { 
            using var channel = GrpcChannel.ForAddress("https://linuxgrpcserver.grpc.appserviceenvironment.net");

            var client = new Greeter.GreeterClient(channel);
            var reply = await client.SayHelloAsync(
                              new HelloRequest { Name = "GreeterClient" });
            Console.WriteLine("Greeting: " + reply.Message);
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message + " " + ex.StackTrace);
}
        