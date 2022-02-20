module Fable.Cumcord.Patcher

open Fable.Core
open Fable.Core.JsInterop
open Fable.Cumcord.Util

[<Import("after", from = "@cumcord/patcher")>]
let private afterRaw: string -> obj -> (obj [] -> obj -> option<obj>) -> bool -> (unit -> unit) = jsNative

let after fName fParent patch =
    afterRaw fName fParent (fun a -> patch (Array.toList a))

[<Import("before", from = "@cumcord/patcher")>]
let private beforeRaw: string -> obj -> (obj [] -> option<obj []>) -> bool -> (unit -> unit) = jsNative

let before fName fParent patch =
    beforeRaw fName fParent (fun a -> patch (Array.toList a) |> nullOrCall List.toArray)

[<ImportMember("@cumcord/patcher")>]
let findAndPatch: (unit -> option<obj>) -> (obj -> unit -> unit) -> (unit -> unit) = jsNative

[<ImportMember("@cumcord/patcher")>]
let injectCSS: string -> (option<string> -> unit) = jsNative

[<Import("instead", from = "@cumcord/patcher")>]
let private insteadRaw: string -> obj -> (string [] -> JsFunc -> option<obj>) -> bool -> (unit -> unit) = jsNative

let instead fName fParent patch =
    insteadRaw fName fParent (fun a -> patch (Array.toList a))