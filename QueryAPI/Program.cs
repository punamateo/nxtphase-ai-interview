using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using QueryAPI.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<ILlmService, LlmService>();
//Añadir esta linea cuando crees el servicio de caché
// builder.Services.AddSingleton<ICacheService, CacheService>();

builder.Services.AddControllers();

var app = builder.Build();

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
