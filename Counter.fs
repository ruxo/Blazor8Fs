namespace Blazor8Fs.Pages

open System
open Microsoft.AspNetCore.Components
open Microsoft.AspNetCore.Components.Web

type private PrivateRenderModeAttribute() =
    inherit RenderModeAttribute()

    override this.Mode = RenderMode.InteractiveServer

[<Route("/counter")>]
[<PrivateRenderMode>]
type Counter() =
    inherit ComponentBase()

    let mutable currentCount = 0

    let countMe() =
        printfn "Counting..."
        currentCount <- currentCount + 1

    override this.BuildRenderTree(builder) =
        builder.OpenComponent<PageTitle>(0)
        builder.AddAttribute(1, "ChildContent", RenderFragment(_.AddContent(0, "Counter")))
        builder.CloseComponent()

        builder.AddMarkupContent(2, "<h1>Counter</h1>")

        builder.OpenElement(3, "p")
        builder.AddContent(4, "Current count: ")
        builder.AddContent(5, currentCount)
        builder.CloseElement()

        builder.OpenElement(7, "button")
        builder.AddAttribute(8, "onclick", EventCallback.Factory.Create<MouseEventArgs>(this, countMe))
        builder.AddContent(9, "Click me")
        builder.CloseElement()