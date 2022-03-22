module Fable.Cumcord.Patcher

open Fable.Core
open Fable.Core.JsInterop
open Fable.Cumcord.Util

[<Import("after", from = "@cumcord/patcher")>]
let private afterRaw (_func: string) (_parent: obj) (_patch: obj [] * obj -> option<obj>) (_oneTime: bool): (unit -> unit) = jsNative

let after fName fParent patch oneTime =
    afterRaw fName fParent (fun (a, r) -> patch (Array.toList a) r) oneTime

[<Import("before", from = "@cumcord/patcher")>]
let private beforeRaw (_func: string) (_parent: obj) (_patch: obj [] -> option<obj []>) (_oneTime: bool): (unit -> unit) = jsNative

let before fName fParent patch oneTime =
    beforeRaw fName fParent (Array.toList >> patch >> (Option.map List.toArray)) oneTime

[<ImportMember("@cumcord/patcher")>]
let findAndPatch (_finder: unit -> option<obj>) (_patch: obj -> unit -> unit): (unit -> unit) = jsNative

[<ImportMember("@cumcord/patcher")>]
let injectCSS: string -> (unit -> unit) = jsNative

[<Import("instead", from = "@cumcord/patcher")>]
let private insteadRaw (_func: string) (_parent: obj) (_patch: string [] * JsFunc -> option<obj>) (_oneTime: bool): (unit -> unit) = jsNative

let instead fName fParent patch oneTime =
    insteadRaw fName fParent (fun (a, f) -> patch (Array.toList a) f) oneTime