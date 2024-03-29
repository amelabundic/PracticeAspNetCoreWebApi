using ActionFilters;
using Contracts;
using Entities;
using LoggerService;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyCompany.ActionFilters;
using MyCompany.Extensions;
using NLog;
using NLog.Extensions.Logging;
using Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers(config =>
{
    config.RespectBrowserAcceptHeader = true;
    config.ReturnHttpNotAcceptable = true;
}).AddNewtonsoftJson()
 .AddXmlDataContractSerializerFormatters();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddPolicy("CorsPolicy", builder =>
    builder.AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader());
});

builder.Services.Configure<ApiBehaviorOptions>(options =>
{
    options.SuppressModelStateInvalidFilter = true;
});

builder.Services.AddScoped<ILoggerManager, LoggerManager>();

builder.Services.ConfigureIISIntegration();
builder.Services.ConfigureLoggerService();

builder.Services.AddLogging(loggingBuilder =>
{
    loggingBuilder.ClearProviders();
    loggingBuilder.AddNLog();
});
builder.Services.AddControllers(config =>
{
    config.RespectBrowserAcceptHeader = true;
}).AddXmlDataContractSerializerFormatters();

builder.Services.AddScoped<IRepositoryManager, RepositoryManager>();

builder.Services.AddDbContext<RepositoryContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});
builder.Services.AddAutoMapper(typeof(MappingProfile));
builder.Services.AddScoped<ValidationFilterAttribute>();
builder.Services.AddScoped<ValidateCompanyExistsAttribute>();
builder.Services.AddScoped<ValidateEmployeeForCompanyExistsAttribute>();

LogManager.LoadConfiguration(string.Concat(Directory.GetCurrentDirectory(), "/nlog.config.txt"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("CorsPolicy");
app.UseForwardedHeaders(new ForwardedHeadersOptions
{
    ForwardedHeaders = ForwardedHeaders.All
});

app.UseDeveloperExceptionPage();
app.UseHttpsRedirection();
app.UseRouting();
app.UseStaticFiles();

app.UseAuthorization();

app.MapControllers();

app.Run();