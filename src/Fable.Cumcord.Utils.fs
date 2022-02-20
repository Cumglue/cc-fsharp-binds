module Fable.Cumcord.Utils

open Browser.Types
open Fable.Core
open Fable.Cumcord.Util

[<ImportMember("@cumcord/utils")>]
let copyText: string -> unit = jsNative

[<ImportMember("@cumcord/utils")>]
let findInReactTree: obj -> (obj -> bool) -> obj = jsNative

type FindInTreeOptionsRaw =
    {walkable: option<string []>
     ignore: option<string []>
     limit: option<int>}

type FindInTreeOptions =
    {walkable: option<string list>
     ignore: option<string list>
     limit: option<int>}

[<Import("findInTree", from = "@cumcord/utils")>]
let private findInTreeRaw: obj -> (obj -> bool) -> option<FindInTreeOptionsRaw> -> obj = jsNative

let private rawifyTreeOptions options : FindInTreeOptionsRaw =
    {walkable = nullOrCall List.toArray options.walkable
     ignore = nullOrCall List.toArray options.ignore
     limit = options.limit}

let findRaw node filter options =
    findInTreeRaw node filter (nullOrCall rawifyTreeOptions options)

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