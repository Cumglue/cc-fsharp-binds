module Fable.Cumcord

open Fable.Core
open Fable.Cumcord.Util

[<Import("cum", from = "@cumcord")>]
let private cumRaw: int -> int -> string = jsNative

let cum cockSize cumshotStrength =
    cumRaw (maybeFallback cockSize 2) (maybeFallback cumshotStrength 6)

[<ImportMember("@cumcord")>]
let uninject: unit -> unit = jsNative