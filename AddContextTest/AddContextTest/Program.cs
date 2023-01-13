using AddContextTest;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

_ = builder.Services.AddBlazoredLocalStorage((options) => {
    options.JsonSerializerOptions.AddContext<MyDataContext>();
});
await builder.Build().RunAsync();
