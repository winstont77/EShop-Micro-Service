﻿using MediatR;
using Microsoft.Extensions.Logging;
using Ordering.Domain.Events;

namespace Ordering.Application.Orders.EventHandlers.Domain;

public class OrderCreatedEventHandler(ILogger<OrderUpdatedEventHandler> logger)
    : INotificationHandler<OrderCreatedEvent>
{
    public Task Handle(OrderCreatedEvent domainEvent, CancellationToken cancellationToken)
    {
        logger.LogInformation("Domain Event handled: {DomainEvent}", domainEvent.GetType().Name);

        return Task.CompletedTask;
    }
}