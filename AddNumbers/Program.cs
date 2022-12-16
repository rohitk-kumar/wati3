var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options => 
{
    options.AddDefaultPolicy(policy =>
    {
        policy.AllowAnyOrigin()
        .AllowAnyHeader()
        .AllowAnyMethod();    
        
    });
});

builder.Services.AddScoped<IAddNumberService, AddNumberService>();
var addNumApp = builder.Build();

addNumApp.UseCors();
addNumApp.Endpoints();

addNumApp.Run();

