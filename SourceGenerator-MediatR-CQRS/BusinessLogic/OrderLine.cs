public record OrderLine(
    int Id,
    int OrderId,
    int ProductId,
    int Quantity,
    decimal Price
);