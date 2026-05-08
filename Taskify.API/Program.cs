using Taskify.Infrastructure.DATA;
using Taskify.Core.Interfaces;
using Taskify.Infrastructure.Repositories;
    
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<DatabaseConnection>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddControllers();


var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.MapGet("/", () => "Taskify API funcionando");

app.MapControllers();

app.Run();