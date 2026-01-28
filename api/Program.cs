using api.Controllers;
using api.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<NewApiServices>();

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddCors(options =>
{
   options.AddPolicy("DemoDevClient", policy => {
        policy.WithOrigins("http://127.0.0.1:5500")
        .AllowAnyHeader()
        .AllowAnyMethod();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    // app.UseSwaggerUI();
    // app.UseSwagger();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseCors("DemoDevClient");

app.MapControllers();

app.Run();
