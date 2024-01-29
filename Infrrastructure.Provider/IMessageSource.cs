using App.Contracts;
using System.Net;

namespace Infrrastructure.Provider;

public interface IMessageSource
{
    Task<ReceiveResult> Receive(CancellationToken cancellationToken);
    Task Send(Message message, IPEndPoint endpoint, CancellationToken cancellationToken);
    //IPEndPoint CreateEndpoint(string address, int port);
    //IPEndPoint GetServerEndPoint();
}
