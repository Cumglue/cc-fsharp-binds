module Fable.Cumcord.Plugins

open Fable.Core
open Fable.Cumcord.Util

(*type PluginManifest = {
    author: string
    description: string
    hash: string
    license: string
    media: option<string>
    name: string
}

type InstalledNestValue = {
    enabled: bool
    js: string
    manifest: PluginManifest
}

type LoadedNestValue = {
    onLoad: option<unit -> unit>
    onUnload: unit -> unit
    settings: option<obj> // TODO: types for React components
}*)

[<ImportMember("@cumcord/plugins")>]
let importPlugins: string -> Async<unit> = jsNative

[<ImportMember("@cumcord/plugins")>]
let installed: Nest<obj> = jsNative

[<ImportMember("@cumcord/plugins")>]
let loaded: Nest<obj> = jsNative

[<ImportMember("@cumcord/plugins")>]
let removePlugin: string -> unit = jsNative

[<ImportMember("@cumcord/plugins")>]
let togglePlugin: string -> unit = jsNative