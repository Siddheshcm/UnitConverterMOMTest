using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using UnitConverterMOMTest.Data;
using UnitConverterMOMTest.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddDbContext<UnitConverterDBContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Constr") ?? throw new InvalidOperationException("Connection string 'UnitConverterMOMTestDBContext' not found.")));

builder.Services.AddTransient<IConverter, Converter>();
builder.Services.AddTransient<IConverter, FakeConverter>();
builder.Services.AddScoped<ConverterDataAccess>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
   
}

//app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
