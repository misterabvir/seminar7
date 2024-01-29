using Core;
using Infrastructure.Persistence.Contexts;
using Infrrastructure.Provider;
using System.Net;
using System.Net.Sockets;

IPEndPoint serverEndpoint = new (IPAddress.Parse("127.0.0.1"), 12000);
IMessageSource source;


if (args.Length == 0)
{
    //server
    source = new MessageSource(new UdpClient(serverEndpoint));

    var chat = new ChatServer(source, new ChatContext());
    await chat.Start();
}
else
{
    //client
    source = new MessageSource(new UdpClient());
    var chat = new ChatClient(args[0], serverEndpoint, source);
    await chat.Start(); 
}
