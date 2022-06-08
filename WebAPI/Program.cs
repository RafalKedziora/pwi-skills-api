using Application.Interfaces;
using Application.Mappings;
using Application.Services;
using Domain.Interfaces;
using Infrastructure.Data;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using WebAPI;

var builder = WebApplication.CreateBuilder(args);

#region Services
builder.Services.AddScoped<IAuthorRepository, AuthorRepository>();
builder.Services.AddScoped<ICommentRepository, CommentRepository>();
builder.Services.AddScoped<ILanguageRepository, LanguageRepository>();
builder.Services.AddScoped<IProjectRepository, ProjectRepository>();
builder.Services.AddScoped<ITechnologyRepository, TechnologyRepository>();

builder.Services.AddScoped<IAuthorService, AuthorService>();
builder.Services.AddScoped<ICommentService, CommentService>();
builder.Services.AddScoped<ILanguageService, LanguageService>();
builder.Services.AddScoped<IProjectService, ProjectService>();
builder.Services.AddScoped<ITechnologyService, TechnologyService>();

builder.Services.AddSingleton(AutoMapperConfig.Initialize());

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddPolicy("Open",
        builder => builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
});

builder.Services.AddDbContext<SkillContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("RevoSkillCS")));
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

app.MapGet("/projects/{languageCode}", (IProjectService service, string languageCode) => service.GetAllProjects(languageCode));
app.MapGet("/projects/{languageCode}/{id}", (IProjectService service, int id, string languageCode) => service.GetProjectByIdByLanguage(id, languageCode));

app.Run();
