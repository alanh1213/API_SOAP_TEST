using API_SOAP.Servicios;
using SoapCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<IAuthorService, AuthorService>();
builder.Services.AddControllers();

var app = builder.Build();

app.UseSoapEndpoint<IAuthorService>("/Service.asmx", new SoapEncoderOptions());
app.UseAuthorization();
app.MapControllers();
app.Run();
