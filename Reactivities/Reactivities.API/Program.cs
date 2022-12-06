using Reactivities.API.Mapper;
using Reactivities.API.Middleware;
using Reactivities.Application;
using Reactivities.Domain;
using Reactivities.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddApplication();
builder.Services.AddInfrastructure(builder.Configuration);
builder.Services.AddPersistence(builder.Configuration);
builder.Services.AddDomain();


//AutoMapper
builder.Services.AddAutoMapper(typeof(MapperConfig));

//CORS
builder.Services.AddCors(options => {
    options.AddPolicy("AllowAll", b => b.AllowAnyHeader().AllowAnyOrigin().AllowAnyMethod());
});


var app = builder.Build();
{
    app.UseMiddleware<ErrorHandlingMiddleware>();

    app.UseHttpsRedirection();
    app.UseCors("AllowAll");
    app.MapControllers();
    app.Run();
}

