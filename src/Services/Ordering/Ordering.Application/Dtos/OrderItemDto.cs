namespace Ordering.Application.Dtos;

//This DTO represents the essential information of each item in an order such as the product ID, quantity and the price.
public record OrderItemDto(Guid OrderId, Guid ProductId, int Quantity, decimal Price);