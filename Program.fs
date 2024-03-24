module Blazor8Fs.Program

open Microsoft.AspNetCore.Builder
open Microsoft.Extensions.Hosting
open Microsoft.Extensions.DependencyInjection

let args = System.Environment.GetCommandLineArgs()
let builder = args |> WebApplication.CreateBuilder
builder.Services
       .AddRazorComponents()
       .AddInteractiveServerComponents()
       .AddInteractiveWebAssemblyComponents()
       |> ignore

let app = builder.Build()

if not (app.Environment.IsDevelopment()) then
    app.UseExceptionHandler("/Error", createScopeForErrors = true) |> ignore
    app.UseHsts() |> ignore

app.UseHttpsRedirection() |> ignore
app.UseStaticFiles() |> ignore
app.UseAntiforgery() |> ignore

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddInteractiveWebAssemblyRenderMode()
|> ignore

app.Run()

