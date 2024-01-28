using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Chambre_API.Model;
using Chambre_API.Repository;
using Chambre_API.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ChambreContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<IChambreRepository, ChambreRepository>();

builder.Services.AddScoped<IChambreService, ChambreService>();

builder.Services.AddControllers();

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Chambre API", Version = "v1" });
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Chambre API V1"));
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
