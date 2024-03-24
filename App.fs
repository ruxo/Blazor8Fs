namespace Blazor8Fs

open Microsoft.AspNetCore.Components
open Microsoft.AspNetCore.Components.Web

type App() =
    inherit ComponentBase()

    override this.BuildRenderTree(builder) =
        builder.AddMarkupContent(0, "<!DOCTYPE html>")
        builder.OpenElement(1, "html")
        builder.AddAttribute(2, "lang", "en")
        builder.OpenElement(3, "head")
        builder.AddMarkupContent(4, """
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <base href="/">
    <link rel="stylesheet" href="bootstrap/bootstrap.min.css">
    <link rel="stylesheet" href="app.css">
    <link rel="stylesheet" href="Blazor8Fs.styles.css">
    <link rel="icon" type="image/png" href="favicon.png">""")
        builder.OpenComponent<HeadOutlet>(5)
        builder.CloseComponent()
        builder.CloseElement()

        builder.OpenElement(7, "body")
        builder.OpenComponent<Routes>(8)
        builder.CloseComponent()
        builder.AddMarkupContent(9, """<script src="_framework/blazor.web.js"></script>""")
        builder.CloseElement()
        builder.CloseElement()

