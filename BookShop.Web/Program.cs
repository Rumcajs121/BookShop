using Blazored.LocalStorage;
using BookShop.Web;
using BookShop.Web.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("http://localhost:5129") });
builder.Services.AddScoped<IBooksService, BookServices>();
builder.Services.AddScoped<EventService>();
builder.Services.AddBlazoredLocalStorage();
await builder.Build().RunAsync();
