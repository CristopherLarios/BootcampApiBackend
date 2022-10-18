using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using TareaBootcamp.DataAcces;


var builder = WebApplication.CreateBuilder(args);

const string CONNECTIONAME = "TareaBootcampDB";
var connectionString = builder.Configuration.GetConnectionString(CONNECTIONAME);

builder.Services.AddDbContext<BootcampDBContext>(Options => Options.UseSqlServer(connectionString));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
