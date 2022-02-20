module Fable.Cumcord.Patcher

open Fable.Core
open Fable.Core.JsInterop

[<ImportMember("@cumcord/patcher")>]
let after: string -> obj -> (obj[] -> obj -> option<obj>) -> bool -> (unit -> unit) = jsNative

[<ImportMember("@cumcord/patcher")>]
let before: string -> obj -> (obj[] -> option<obj[]>) -> bool -> (unit -> unit) = jsNative

[<ImportMember("@cumcord/patcher")>]
let findAndPatch: (unit -> option<obj>) -> (obj -> unit -> unit) -> (unit -> unit) = jsNative

[<ImportMember("@cumcord/patcher")>]
let injectCSS: string -> (option<string> -> unit) = jsNative

[<ImportMember("@cumcord/patcher")>]
let instead: string -> obj -> (string[] -> JsFunc -> option<obj>) -> bool -> (unit -> unit) = jsNative