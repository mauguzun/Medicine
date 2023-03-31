using Medicine.Auth;
using Medicine.DataAccess.Interfaces;
using Medicine.DataAccess.Sql;
using Medicine.Web.UseCases.Utils;
using Medicine.WebApplication.GraphQL.Reminder.Queries;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


builder.Services.AddAuthorization();
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidIssuer = AuthOptions.ISSUER,
            ValidateAudience = true,
            ValidAudience = AuthOptions.AUDIENCE,
            ValidateLifetime = true,
            IssuerSigningKey = AuthOptions.GetSymmetricSecurityKey(),
            ValidateIssuerSigningKey = true,
        };
    });

builder.Services.AddControllers()
        .AddNewtonsoftJson(options =>
    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
);


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


ConfigurationManager configuration = builder.Configuration;

//Add database
builder.Services.AddDbContext<IAppDbContext, AppDbContext>(builder => builder.UseSqlServer(configuration["connectionString"]));
builder.Services.AddDbContext<IAppDbContextReadonly, AppDbContextReadOnly>(builder => builder.UseSqlServer(configuration["connectionString"]));

builder.Services.AddGraphQLServer()
     .AddAuthorization()
    .AddQueryType<ReminderQuery>()
    .AddMutationType<ReminderMutation>()
    .AddProjections()
    .AddFiltering()
    .AddSorting();

builder.Services.AddAutoMapper(typeof(MapperProfile));

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

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.MapGraphQL("/graphql");

app.Run();
