using MediatR;
using System.Threading;
using System.Threading.Tasks;

public record CommandHandlers : IRequestHandler<CreateOrder, string>,
    IRequestHandler<AddProduct, string>,
    IRequestHandler<RemoveProduct, string>,
    IRequestHandler<CancelOrder, string>
{
    public Task<string> Handle(CreateOrder request, CancellationToken cancellationToken) => 
        Task.FromResult($"Order created{request.Id}");

    public Task<string> Handle(AddProduct request, CancellationToken cancellationToken) => 
        Task.FromResult("Product added");

    public Task<string> Handle(RemoveProduct request, CancellationToken cancellationToken) => 
        Task.FromResult("Product removed");

    public Task<string> Handle(CancelOrder request, CancellationToken cancellationToken) => 
        Task.FromResult("Order cancelled");
}