var builder = WebApplication.CreateBuilder(args);


public void Factory(ConfigureServices, ConfigureConfiguration)

public void ConfigureConfiguration(IConfiguration configuration)
{

}

public void ConfigureServices(IServiceCollection services)
{
    services.AddControllers();
    services.AddOpenApi();
    services.AddScoped<UserOrchestrator>();
}

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
