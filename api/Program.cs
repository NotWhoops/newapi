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
        policy.WithOrigins("http://127.0.0.1:5500", "https://thankful-bush-0f668ff1e.2.azurestaticapps.net")
        .AllowAnyHeader()
        .AllowAnyMethod();
    });
});

var app = builder.Build();


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
