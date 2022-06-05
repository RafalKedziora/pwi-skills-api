using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using WebAPI;

var builder = WebApplication.CreateBuilder(args);

#region Services

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddPolicy("Open",
        builder => builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
});

builder.Services.AddDbContext<SkillContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("RevoSkillCS")));
builder.Services.AddTransient<DataSeeder>();
#endregion

var app = builder.Build();

#region Seeder
SeedData(app);
void SeedData(WebApplication app)
{
    var scopedFactory = app.Services.GetService<IServiceScopeFactory>();
    using (var scope = scopedFactory.CreateScope())
    {
        var service = scope.ServiceProvider.GetService<DataSeeder>();
        service.Seed();
    }
}
#endregion

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors("Open");
