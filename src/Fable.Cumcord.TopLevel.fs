module Fable.Cumcord.TopLevel

open Fable.Core
open Fable.Cumcord.Util

[<ImportMember("@cumcord")>]
let cum (_size: int option) (_strength: int option): string = jsNative

[<ImportMember("@cumcord")>]
let uninject(): unit = jsNative