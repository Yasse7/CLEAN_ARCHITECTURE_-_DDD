using BuberDinner.Application;
using BuberDinner.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
{
builder.Services.AddControllers();
builder.Services.AddApplication()
                .AddInfrastructure()
;



}
// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
 
var app = builder.Build();
{
app.UseHttpsRedirection();
app.MapControllers();

 
app.Run();

}

// Configure the HTTP request pipeline.
 

 
