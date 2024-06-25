using Ordering.Domain.ValueObjects;

namespace Ordering.Application.Dtos;

//Payment DTO represent payment value object from our domain layer for that purpose.
public record PaymentDto(string CardName, string CardNumber, string Expiration, string Cvv, int PaymentMethod);