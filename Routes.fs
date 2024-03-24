namespace Blazor8Fs

open System
open System.Reflection
open Microsoft.AspNetCore.Components
open Microsoft.AspNetCore.Components.CompilerServices
open Microsoft.AspNetCore.Components.Rendering
open Microsoft.AspNetCore.Components.Routing

type Routes() =
    inherit ComponentBase()

    override this.BuildRenderTree(builder) =
        builder.OpenComponent<Router>(0)
        builder.AddComponentParameter(1, "AppAssembly", RuntimeHelpers.TypeCheck<Assembly>(typeof<Routes>.Assembly))

        let inner routeData (builder: RenderTreeBuilder) =
            builder.OpenComponent<RouteView>(0)
            builder.AddComponentParameter(1, "RouteData", RuntimeHelpers.TypeCheck<RouteData>(routeData))
            builder.AddComponentParameter(2, "DefaultLayout", RuntimeHelpers.TypeCheck<Type>(typeof<MainLayout>))
            builder.CloseComponent()
            builder.AddMarkupContent(3, "\r\n        ")
            builder.OpenComponent<FocusOnNavigate>(4)
            builder.AddComponentParameter(5, "RouteData", RuntimeHelpers.TypeCheck<RouteData>(routeData))
            builder.AddComponentParameter(6, "Selector", "h1")
            builder.CloseComponent()

        builder.AddAttribute(2, "Found", RenderFragment<RouteData>(fun (routeDate: RouteData) -> RenderFragment (inner routeDate)))
        builder.CloseComponent()
