namespace Blazor8Fs.Pages

open Microsoft.AspNetCore.Components
open Microsoft.AspNetCore.Components.Rendering
open Microsoft.AspNetCore.Components.Web

[<Route "/">]
type Home() =
    inherit ComponentBase()

    override this.BuildRenderTree(builder) =
        builder.OpenComponent<PageTitle>(0)
        builder.AddAttribute(1, "ChildContent", RenderFragment(fun (b: RenderTreeBuilder) -> b.AddContent(0, "Home")))
        builder.CloseComponent()

        builder.AddMarkupContent(2, "\r\n\r\n")
        builder.AddMarkupContent(3, "<h1>Hello world!</h1>")
