using MediatR;
using System.Collections.Generic;


public interface IQuery<T> : IRequest<T>
{
}

public record ListAllOrders : IQuery<List<Order>>;

public record ListAllOrdersForCustomer : IQuery<List<Order>>
{
    int CustomerID;
}

public record ListTodaysOrders : IQuery<List<Order>>
{
    int CustomerID;
}


public record GetOrder : IQuery<Order>
{
    int OrderId;
}