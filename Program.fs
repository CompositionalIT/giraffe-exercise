open Giraffe
open Microsoft.AspNetCore.Builder
open Microsoft.AspNetCore.Http
open Microsoft.Extensions.Primitives
open Microsoft.Net.Http.Headers
open System.Text
open System.Threading.Tasks
open Saturn

let myWebApp = router {
    get "/" (text "Hello")
}




let app =
    application {
        url "http://0.0.0.0:5000"
        use_router myWebApp
    }

run app

