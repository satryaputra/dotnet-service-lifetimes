var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<IServiceSingleton, Service>();
builder.Services.AddScoped<IServiceScoped, Service>();
builder.Services.AddTransient<IServiceTransient, Service>();

var app = builder.Build();

app.MapGet("/", Services);

app.Run();

static string Services(
    IServiceSingleton singleton, 
    IServiceScoped scoped1, 
    IServiceScoped scoped2, 
    IServiceTransient transient1, 
    IServiceTransient transient2)
{
    var singletonInfo = $"Singleton instance: {singleton.Id}";
    
    var scopedInfo = $"Scoped instance 1: {scoped1.Id}\r\n" +
                     $"Scoped instance 2: {scoped2.Id}";
                     
    var transientInfo = $"Transient instance 1: {transient1.Id}\r\n" +
                        $"Transient instance 2: {transient2.Id}";

    return $"{singletonInfo}\r\n\r\n{scopedInfo}\r\n\r\n{transientInfo}";
}

interface IService
{
    public Guid Id { get; set; }
}

interface IServiceSingleton : IService
{
}

interface IServiceScoped : IService
{
}

interface IServiceTransient : IService
{
}

class Service : IServiceSingleton, IServiceScoped, IServiceTransient
{
    public Guid Id { get; set; } = Guid.NewGuid();
}