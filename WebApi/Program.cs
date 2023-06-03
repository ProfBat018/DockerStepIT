using Microsoft.EntityFrameworkCore;
using WebApi.Data.DbContexts;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//builder.Services.AddCors(options =>
//{
//    options.AddPolicy(name: "dockerOrigin",
//                      policy =>
//                      {
//                          policy.WithOrigins("http://localhost:3000", "http://localhost:80/");
//                      });
//});

builder.Services.AddDbContext<StoreContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("Store")));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();
//app.UseCors("dockerOrigin");

app.MapControllers();

app.Run();
