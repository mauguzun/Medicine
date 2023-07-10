using Medicine.Application.Implementation;
using Medicine.Application.Interfaces;
using Medicine.Entities.Models.Auth;
using Medicine.Infrastructure.Implementation.DataAccesMssql;
using Medicine.Infrastructure.Implementation.GmailNotification;
using Medicine.Infrastructure.Interfcases.DataAccess;
using Medicine.Infrastructure.Interfcases.Notification;
using Medicine.Web.UseCases.DataLoaders.BaseDataLoader;
using Medicine.Web.UseCases.DataLoaders.TranslateDataLoader;
using Medicine.Web.UseCases.Utils;
using Medicine.WebApplication;
using Medicine.WebApplication.GraphQL.Entities.Reminder.Mutatiion;
using Medicine.WebApplication.GraphQL.Entities.Reminder.Query;
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


//dataAcess
builder.Services.AddDbContext<IAppDbContext, AppDbContext>(builder => builder.UseNpgsql(connnectionString));
builder.Services.AddDbContext<IAppDbContextReadonly, AppDbContextReadOnly>(builder => builder.UseNpgsql(connnectionString));


// infrastracture

builder.Services.AddScoped<IEmailService, GmailService>();

// application

builder.Services.AddScoped<ILanguageService, LanguageService>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IReminderService, ReminderService>();

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




builder.Services.AddScoped(typeof(IResponseLoader<,,>), typeof(ResponseLoader<,,>));
builder.Services.AddScoped(typeof(ITranslateResponseLoader<,,>), typeof(TranslateResponseLoader<,,>));



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
