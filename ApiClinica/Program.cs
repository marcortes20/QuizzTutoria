using Servicios.Clinicas;
using Servicios.ExpedientesMedicos;
using Servicios.Usuarios;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<ISvClinica, SvClinica>();
builder.Services.AddScoped<ISvUsuario, SvUsuario>();
builder.Services.AddScoped<ISvExpedienteMedico, SvExpedienteMedico>();


builder.Services.AddControllers()
    .AddNewtonsoftJson(x =>
 x.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);

builder.Services.AddCors(options =>
{
    options.AddPolicy("Policy1", builder =>
    {
        builder.WithOrigins("https://localhost:5173")
            .WithMethods("GET", "POST")
            .WithHeaders("Content-Type");
    });

});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();





