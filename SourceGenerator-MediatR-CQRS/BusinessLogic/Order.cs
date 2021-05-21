using System.Collections.Generic;

public record Order(
    int Id,
    int CustomerId,
    List<OrderLine> OrderLines,
    decimal OrderTotal
);