using Blazored.LocalStorage;
using Blazored.Toast;
using iita_par;
using iita_par.Authentication;
using iita_par.Services;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddBlazoredLocalStorage();
builder.Services.AddScoped(sp =>
{
    var client = new HttpClient(new CustomAuthorizationMessageHandler(sp.GetRequiredService<ILocalStorageService>()))
    {
        BaseAddress = new Uri("https://iitaparapi.azurewebsites.net/api/")
    };
    return client;
});

builder.Services.AddAuthorizationCore();
builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthenticationStateProvider>();
builder.Services.AddBlazoredToast();
builder.Services.AddSingleton<LoadingService>();

await builder.Build().RunAsync();
