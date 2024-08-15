using Microsoft.EntityFrameworkCore;
using MyWebAPI.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// Add Databases
builder.Services.AddDbContext<DataContext>(options =>
{
	options.UseSqlite("FileName=./WebApiDatabase.db");
});
// Add all controller
builder.Services.AddControllers();
var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}
app.UseHttpsRedirection();

// Add mapping Controller
app.MapControllers();
app.Run();
