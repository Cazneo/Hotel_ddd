using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Payment_API.Model;
using Payment_API.Repository;
using Payment_API.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<PaymentContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<IDeviseRepository, DeviseRepository>();
builder.Services.AddScoped<IWalletRepository, WalletRepository>(); 

builder.Services.AddScoped<IDeviseService, DeviseService>();
builder.Services.AddScoped<IWalletService, WalletService>();

builder.Services.AddControllers();

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Payment API", Version = "v1" });
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Payment API V1"));
}

app.UseHttpsRedirection();
app.UseAuthorization();

app.MapControllers();

app.Run();
