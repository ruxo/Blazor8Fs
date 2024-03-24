namespace Blazor8Fs

open Microsoft.AspNetCore.Components

type MainLayout() =
    inherit LayoutComponentBase()

    override this.BuildRenderTree(builder) =
        builder.OpenElement(0, "div")
        builder.AddContent(1, this.Body)
        builder.CloseElement()

