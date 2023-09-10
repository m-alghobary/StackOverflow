using Microsoft.EntityFrameworkCore;
using StackOverflow.Data;
using StackExchange.Profiling.Storage;

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


builder.Services.AddMiniProfiler(options =>
{
    (options.Storage as MemoryCacheStorage).CacheDuration = TimeSpan.FromMinutes(5);
}).AddEntityFramework();


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
app.UseMiniProfiler();


app.Run();
