module Fable.Cumcord.Utils

open Browser.Types
open Fable.Core
open Fable.Cumcord.Util

[<ImportMember("@cumcord/utils")>]
let copyText: string -> unit = jsNative

[<ImportMember("@cumcord/utils")>]
let findInReactTree: obj -> (obj -> bool) -> obj = jsNative

type FindInTreeOptions = {
    walkable: option<string[]>
    ignore: option<string[]>
    limit: option<int>
}

[<ImportMember("@cumcord/utils")>]
let findInTree: obj -> (obj -> bool) -> option<FindInTreeOptions> -> obj = jsNative

[<ImportMember("@cumcord/utils")>]
let getOwnerInstance: obj -> obj = jsNative

[<ImportMember("@cumcord/utils")>]
let getReactInstance: HTMLElement -> obj = jsNative

[<ImportMember("@cumcord/utils")>]
let sleep: int -> Async<unit> = jsNative

[<ImportMember("@cumcord/utils")>]
let useNest<'a> : Nest<'a> -> unit = jsNative

module Logger =
    [<ImportMember("@cumcord/utils/logger")>]
    let log: string -> unit = jsNative
    
    [<ImportMember("@cumcord/utils/logger")>]
    let warn: string -> unit = jsNative
    
    [<ImportMember("@cumcord/utils/logger")>]
    let error: string -> unit = jsNative