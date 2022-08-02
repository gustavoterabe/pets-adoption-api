using Microsoft.EntityFrameworkCore;
using Npgsql;
using petAdoptionApi.Models;
using petAdoptionApi.Models.Start_Model;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("PetAdoptionDB");

builder.Services.AddDbContext<PetAdoptionContext>(options =>
    options.UseNpgsql(connectionString));
// Add services to the container.

using (var context = new PetAdoptionContext())
{

    var std = new Pet()
    {
        Name = "Bill",
        Breed = "Ponei"
    };

    context.pets.Add(std);
    context.SaveChanges();
}

builder.Services.AddOptions();
builder.Services.AddControllers();
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
