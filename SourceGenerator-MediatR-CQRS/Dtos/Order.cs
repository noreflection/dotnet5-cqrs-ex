using System.Collections.Generic;

public record Order(
    int Id,
    int CustomerId,
    List<OrderLine> OrderLines,
    decimal OrderTotal
);

public record OrderLine(
    int Id,
    int OrderId,
    int ProductId,
    int Quantity,
    decimal Price
);
