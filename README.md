# Cumcord bindings for F# Fable

[More info about Fable](https://fable.io)

## An example of an F# plugin:

```fs
// TODO
// see https://github.com/Cumglue/cc-fsharp-templates/blob/master/templates/plugin/src/App.fs
```

### Note for contributors
To publish to NuGet, please instead of anything manual do the following:
 1. Add a version note to RELEASE_NOTES.md. This is crucial. This also sets the ver num.
 2. Get a NuGet API key *for the cumglue org*
 3. Run `FABLE_NUGET_KEY=[api key] dotnet fsi build.fsx publish`