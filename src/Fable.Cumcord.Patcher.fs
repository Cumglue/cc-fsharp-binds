module Fable.Cumcord.Patcher

open Fable.Core
open Fable.Core.JsInterop
open Fable.Cumcord.Util

[<Import("after", from = "@cumcord/patcher")>]
let private afterRaw: string * obj * (obj [] * obj -> option<obj>) * bool -> (unit -> unit) = jsNative

let after fName fParent patch oneTime =
    afterRaw (fName, fParent, (fun (a, r) -> patch (Array.toList a) r), oneTime)

[<Import("before", from = "@cumcord/patcher")>]
let private beforeRaw: string * obj * (obj [] -> option<obj []>) * bool -> (unit -> unit) = jsNative

let before fName fParent patch oneTime =
    beforeRaw (fName, fParent, (Array.toList >> patch >> (Option.map List.toArray)), oneTime)

[<Import("findAndPatch", from = "@cumcord/patcher")>]
let private findAndPatchRaw: (unit -> option<obj>) * (obj -> unit -> unit) -> (unit -> unit) = jsNative

let findAndPatch finder patch = findAndPatchRaw (finder, patch)

[<ImportMember("@cumcord/patcher")>]
let injectCSS: string -> (option<string> -> unit) = jsNative

[<Import("instead", from = "@cumcord/patcher")>]
let private insteadRaw: string * obj * (string [] * JsFunc -> option<obj>) * bool -> (unit -> unit) = jsNative

let instead fName fParent patch oneTime =
    insteadRaw (fName, fParent, (fun (a, f) -> patch (Array.toList a) f), oneTime)