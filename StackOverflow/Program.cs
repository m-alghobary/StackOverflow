using Microsoft.EntityFrameworkCore;
using StackOverflow.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DB"), opt =>
    {
        // this is needed to be able to run the init migration,
        // cuz creating indexes takes more than the default 30s 
        opt.CommandTimeout((int)TimeSpan.FromMinutes(5).TotalSeconds);
    });
    options.EnableSensitiveDataLogging();
});

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
