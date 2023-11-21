#region Builder
using InOutVehicleManager.Api.Extensions;
using InOutVehicleManager.Api.Extensions.Contexts.CompanyContext;
using InOutVehicleManager.Api.Extensions.Contexts.EmployeeContext;
using InOutVehicleManager.Api.Extensions.Contexts.VehicleContext;

var builder = WebApplication.CreateBuilder(args);

builder.AddConfiguration();
builder.AddDatabase();
builder.AddJwtAuthentication();

builder.AddVehicleContext();
builder.AddEmployeeContext();
builder.AddParkingContext();
builder.AddCompanyContext();

builder.AddMediatr();
builder.AddSwaggerGen();

#endregion

#region App
var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

var configuration = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
    .Build();

app.MapVehicleEndpoints();
app.MapEmployeeEndpoint();
app.MapParkingEndPoint();
app.MapCompanyEndpoint();

app.Run();
#endregion