using Blazored.LocalStorage;
using CareSchedulr.Client;
using CareSchedulr.Client.Services;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddBlazoredLocalStorage();
builder.Services.AddMudServices();
builder.Services.AddScoped<AuthService>();
builder.Services.AddApiAuthorization();
builder.Services.AddScoped<AuthenticationService>();

builder.Services.AddAuthorizationCore();
builder.Services.AddCascadingAuthenticationState();

builder.Services.AddSingleton<AuthenticationStateProvider, PersistentAuthenticationStateProvider>();
builder.Services.AddSingleton<AppointmentService>();

await builder.Build().RunAsync();
