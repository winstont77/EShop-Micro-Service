# EShop-Micro-Service

## Description

As time goes by, the MVC architecture seems no longer to be the best choice for high traffic and high concurrency. In an era that emphasizes agile development, microservices have emerged accordingly. To gain a more practical understanding of microservices, I directly created a microservices project to personally experience the advantages and disadvantages of microservices.

This project will use e-commerce to demonstrate microservices. In daily life, e-commerce is a very relevant topic. Especially during special holidays, e-commerce websites often face several times the usual traffic and concurrency. Therefore, I personally believe that e-commerce is an excellent research subject.


## System architecture

![Image](https://i.imgur.com/OsYwVKo.png)

## Requirement

- Language
  - C# 12
- Famework
  - .Net Core 8
  - Entity Framework Core
- Database
  - Postgres
  - SQLite
  - Redis
  - SQL Server
- Library
  - MediatR
  - Marten
  - Mapster
  - Carter
  - Microsoft.EntityFrameworkCore.Sqlite
  - Microsoft.EntityFrameworkCore.Tools
  - Grpc.AspNetCore
  - FluentValidation
  - FeatureManagement
  - Scrutor
  - MassTransit
  - Microsoft.Extensions.Caching.StackExchangeRedis
  - AspNetCore.HealthChecks.SqlServer
  - AspNetCore.HealthChecks.NpgSql
  - AspNetCore.HealthChecks.Redis
  - AspNetCore.HealthChecks.UI.Client
  - Microsoft.EntityFrameworkCore.Design
- Container
  - Docker

## Functional Map

![Image](https://i.imgur.com/kaPvjqa.png)

#### Catalog microservice which includes 
* ASP.NET Core Minimal APIs and latest features of .NET8 and C# 12
* Vertical Slice Architecture implementation with Feature folders and single .cs file includes different classes in one file
* CQRS implementation using MediatR library
* CQRS Validation Pipeline Behaviors with MediatR and FluentValidation
* Use Marten library for .NET Transactional Document DB on PostgreSQL
* Use Carter for Minimal API endpoint definition
* Cross-cutting concerns Logging, Global Exception Handling and Health Checks

#### Basket microservice which includes
* ASP.NET 8 Web API application, Following REST API principles, CRUD
* Using Redis as a Distributed Cache over basketdb
* Implements Proxy, Decorator and Cache-aside patterns
* Consume Discount Grpc Service for inter-service sync communication to calculate product final price
* Publish BasketCheckout Queue with using MassTransit and RabbitMQ

#### Discount microservice which includes;

* ASP.NET Grpc Server application
* Build a Highly Performant inter-service gRPC Communication with Basket Microservice
* Exposing Grpc Services with creating Protobuf messages
* Entity Framework Core ORM — SQLite Data Provider and Migrations to simplify data access and ensure high performance
* SQLite database connection and containerization

#### Microservices Communication

* Sync inter-service gRPC Communication
* Async Microservices Communication with RabbitMQ Message-Broker Service
* Using RabbitMQ Publish/Subscribe Topic Exchange Model
* Using MassTransit for abstraction over RabbitMQ Message-Broker system
* Publishing BasketCheckout event queue from Basket microservices and Subscribing this event from Ordering microservices
* Create RabbitMQ EventBus.Messages library and add references Microservices

#### Ordering Microservice

* Implementing DDD, CQRS, and Clean Architecture with using Best Practices
* Developing CQRS with using MediatR, FluentValidation and Mapster packages
* Consuming RabbitMQ BasketCheckout event queue with using MassTransit-RabbitMQ Configuration
* SqlServer database connection and containerization
* Using Entity Framework Core ORM and auto migrate to SqlServer when application startup

#### Yarp API Gateway Microservice

* Develop API Gateways with Yarp Reverse Proxy applying Gateway Routing Pattern
* Yarp Reverse Proxy Configuration; Route, Cluster, Path, Transform, Destinations
* Rate Limiting with FixedWindowLimiter on Yarp Reverse Proxy Configuration

## Installing

* Install Docker Desktop
* Install Visaul Studio 2022
* Clone the project:
```
git clone https://github.com/winstont77/EShop-Micro-Service.git
```

## Start Up


Run docker-compose without debugging on visual studio. Or you can go to root directory which include docker-compose.yml files, run below command:
```
docker-compose -f docker-compose.yml -f docker-compose.override.yml up -d
```

After docker compose all microservices, you can use the web application.

![Image](https://i.imgur.com/kjd91p1.png)

## Authors

Winston Hsu
- [部落格](https://chi-keke.github.io/)
- [LinkedIn](https://www.linkedin.com/in/winston-syu-a90a8b214/)
