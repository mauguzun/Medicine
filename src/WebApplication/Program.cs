using Medicine.Auth;
using Medicine.DataAccess.Interfaces;
using Medicine.DataAccess.Sql;
using Medicine.Entities.Models.Auth;
using Medicine.Web.UseCases.Utils;
using Medicine.WebApplication.GraphQL.Reminder.Queries;
using Medicine.WebApplication.HttpHandler;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.IdentityModel.Tokens;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var tokenOptions = new TokenSettings();
builder.Configuration.GetSection(nameof(TokenSettings)).Bind(tokenOptions);
builder.Services.Configure<TokenSettings>(builder.Configuration.GetSection(nameof(TokenSettings)));

// add authoriztion





builder.Services.AddIdentity<User, Role>(options =>
{
    options.User.RequireUniqueEmail = true;
    options.SignIn.RequireConfirmedAccount = true;

})
    .AddRoleManager<RoleManager<Role>>()
    .AddDefaultTokenProviders()
    .AddEntityFrameworkStores<AppDbContextReadOnly>();



builder.Services.AddAuthorization();
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidIssuer = tokenOptions.Issuer,
            ValidateAudience = true,
            ValidAudience = tokenOptions.Issuer,
            ValidateLifetime = true,
            IssuerSigningKey = tokenOptions.GetSymmetricSecurityKey(),
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


var connnectionString = builder.Configuration["connectionString"];


//dataaccess
builder.Services.AddDbContext<IAppDbContext, AppDbContext>(builder => builder.UseSqlServer(connnectionString));
builder.Services.AddDbContext<IAppDbContextReadonly, AppDbContextReadOnly>(builder => builder.UseSqlServer(connnectionString));


// graphql
builder.Services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();

builder.Services.AddGraphQLServer()
    .AddHttpRequestInterceptor<HttpRequestInterceptor>()
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

//app.UseEndpoints(endpoints =>
//{
//    endpoints.MapGraphQL().RequireAuthorization();
//});



app.Run();
