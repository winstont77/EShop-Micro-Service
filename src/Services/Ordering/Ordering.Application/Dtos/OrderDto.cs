using Microsoft.VisualBasic;
using Ordering.Domain.Enums;
using Ordering.Domain.Models;

namespace Ordering.Application.Dtos;

//This DTO represent a complete order including customer details, shipping, billing address, payment information and items within the order.
public record OrderDto(
    Guid Id,
    Guid CustomerId,
    string OrderName,
    AddressDto ShippingAddress,
    AddressDto BillingAddress,
    PaymentDto Payment,
    OrderStatus Status,
    List<OrderItemDto> OrderItems);