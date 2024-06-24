using EF.CodeFirst.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<Apbd9Context, Apbd9Context>();
builder.Services.AddControllers();

builder.Services.AddDbContext<Apbd9Context>(opt =>
{
    // opt.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
    opt.UseInMemoryDatabase("memoryDb");
});

var app = builder.Build();

// !! Upewiam się że mam dane w "InMemory database"!!!!
using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<Apbd9Context>();
    dbContext.Database.EnsureCreated();
}
app.UseHttpsRedirection();
app.MapControllers();
app.UseSwagger();
app.UseSwaggerUI();
        
app.Run();