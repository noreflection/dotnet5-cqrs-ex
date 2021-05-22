using System.ComponentModel.DataAnnotations;
using MediatR;

public interface ICommand<T> : IRequest<T>
{
}

public record CreateOrder : ICommand<string>
{
    [Required] public int Id;
    [Required] public int CustomerId;
}

public record AddProduct : ICommand<string>
{
    [Required] int OrderId;
    [Required] int ProductId;
    [Required] int Quantity;
}

public record RemoveProduct : ICommand<string>
{
    [Required] int OrderId;
    [Required] int ProductId;
}

public record CancelOrder : ICommand<string>
{
    [Required] int OrderId;
    [Required] string Reason;
    [Required] string CancelledBy;
}