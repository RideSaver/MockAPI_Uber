using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using System.Security.Cryptography.X509Certificates;
using UberAPI.Interface;
using UberAPI.Repository;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHealthChecks();

builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.PropertyNameCaseInsensitive = true;
    options.JsonSerializerOptions.NumberHandling = System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString;
});

builder.Services.AddTransient<IEstimateRepository, EstimateRepository>();
builder.Services.AddTransient<IProductRepository, ProductRepository>();
builder.Services.AddTransient<IRequestRepository, RequestRepository>();

builder.Services.Configure<ListenOptions>(options =>
{
    options.UseHttps(new X509Certificate2(Path.Combine("/certs/tls.crt"), Path.Combine("/certs/tls.key")));
});


var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseForwardedHeaders(new ForwardedHeadersOptions
{
    ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto
});

app.UseExceptionHandler(new ExceptionHandlerOptions() { AllowStatusCode404Response = true, ExceptionHandlingPath = "/error" });

app.UseHttpsRedirection();
app.MapControllers();
app.MapHealthChecks("/healthz");
app.UseRouting();

app.Logger.LogInformation("[UberAPI] Finished middleware configuration.. starting the MockAPI...");

app.Run();
