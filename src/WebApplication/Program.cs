using Medicine.DataAccess.Interfaces;
using Medicine.DataAccess.Sql;
using Medicine.WebApplication.GraphQl;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers()
        .AddNewtonsoftJson(options =>
    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
);
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


ConfigurationManager configuration = builder.Configuration;

//Add database
builder.Services.AddDbContext<IAppDbContext, AppDbContext>(builder =>builder.UseSqlServer(configuration["connectionString"]));
builder.Services.AddDbContext<IAppDbContextReadonly, AppDbContextReadOnly>(builder =>builder.UseSqlServer(configuration["connectionString"]));

builder.Services.AddGraphQLServer()
    .AddQueryType<Queries>()
    .AddProjections()
    .AddFiltering()
    .AddSorting();



builder.Services.AddCors(options =>
{
    options.AddPolicy("MyPolicy", builder =>
    {
        builder
            .AllowAnyOrigin()
            //.WithOrigins("http://localhost:4200")
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});

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

app.MapGraphQL("/graphql");

app.Run();
