using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using GeometriaModels.DALs;
using GeometriaModels.Models;
using GeometriaModels.Services;
using GeometriaDesktop;
//host es el contenedor principal de la aplicación.
var host = Host.CreateDefaultBuilder()
.ConfigureServices((context, services) =>
{
    #region Registro de DALs
    services.AddSingleton<IFigurasDAL, FigurasListDAL>();
    #endregion

    #region Registro de services.
    services.AddSingleton <FigurasService>();
    #endregion


    #region Registro de las vistas
    services.AddTransient<FormPrincipal>();
    #endregion
})
.Build();

ApplicationConfiguration.Initialize();
var form = host.Services.GetRequiredService<FormPrincipal>();
Application.Run(form);