// Program.cs
using JobReferral.Application.Services;
using JobReferral.Domain.Interfaces;
using JobReferral.Infrastructure.Repositories;
using Swashbuckle.AspNetCore;
using Microsoft.OpenApi.Models;               
// no 'using' around builder

var builder = WebApplication.CreateBuilder(args);

// 1) Register CORS & Controllers
builder.Services.AddCors(opts =>
  opts.AddDefaultPolicy(policy =>
    policy.AllowAnyOrigin()
          .AllowAnyMethod()
          .AllowAnyHeader()));

builder.Services.AddControllers();

// 2) Register SwaggerGen
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Job Referral API",
        Version = "v1"
    });
});

// 3) Register your DI services
builder.Services.AddScoped<IAuthService, AuthService>();
builder.Services.AddScoped<IReferralService, ReferralService>();
builder.Services.AddScoped<IProfileRepository, MockProfileRepository>();
builder.Services.AddScoped<IReferralRequestRepository, MockReferralRequestRepository>();
builder.Services.AddScoped<IReferrerRepository, MockReferrerRepository>();
builder.Services.AddScoped<IRequestRepository, MockRequestRepository>();
builder.Services.AddScoped<IReferralCardRepository, MockReferralCardRepository>();
builder.Services.AddScoped<IHomeService, HomeService>();

var app = builder.Build();

// 4) Enable middleware
app.UseCors();
app.UseSwagger();            // <-- now available
app.UseSwaggerUI(c =>        // <-- now available
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Job Referral API v1");
});

app.MapControllers();

app.Run();
