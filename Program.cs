using Microsoft.EntityFrameworkCore;
using Web_Api_code_First_Demo_many_to_many.Models;
using Web_Api_code_First_Demo_many_to_many.Repositories;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddTransient<IStudentCourseRepo, StudentCourseRepo>();
// Add services to the container.
builder.Services.AddDbContext<StudentCourseDbContext>(opts=>
opts.UseSqlServer(builder.Configuration["ConnectionStrings:myconnection"]));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//builder.Services.AddEndpointsApiExplorer();
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
