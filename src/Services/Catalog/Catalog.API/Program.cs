var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCarter();

// Give the type of program.cs that means this class and give the assembly name when registering services into mediator.
// Add service to the container.
builder.Services.AddMediatR(config =>
{
    config.RegisterServicesFromAssembly(typeof(Program).Assembly);
});

builder.Services.AddMarten(opts =>
{
    opts.Connection(builder.Configuration.GetConnectionString("CatalogDb")!);
}).UseLightweightSessions();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

// Configure the HTTP request pipeline.
app.MapCarter();

app.Run();
