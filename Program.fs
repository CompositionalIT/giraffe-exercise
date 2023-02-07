open Giraffe
open Microsoft.AspNetCore.Builder
open Microsoft.AspNetCore.Http
open Microsoft.Extensions.Primitives
open Microsoft.Net.Http.Headers
open System.Text
open System.Threading.Tasks

let myWebApp next (ctx: HttpContext) =
    // REPLACE WITH YOUR WEB APP IMPLEMENTATION!
    task { return None }







// This is boilerplate to create an ASP .NET Core web application
let builder = WebApplication.CreateBuilder()
builder.Services.AddGiraffe() |> ignore
let app = builder.Build()
app.UseGiraffe myWebApp
app.Run()
