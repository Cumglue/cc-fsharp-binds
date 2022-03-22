module Fable.Cumcord.Utils

open Browser.Types
open Fable.Core
open Fable.Core.JS
open Fable.Cumcord.Util

[<ImportMember("@cumcord/utils")>]
let copyText (_txt: string) : unit = jsNative

[<ImportMember("@cumcord/utils")>]
let findInReactTree (_node: obj) (_filter: obj -> bool) : obj = jsNative

type private FindInTreeOptionsRaw =
    {walkable: option<string []>
     ignore: option<string []>
     limit: option<int>}

type FindInTreeOptions =
    {walkable: option<string list>
     ignore: option<string list>
     limit: option<int>}

[<Import("findInTree", from = "@cumcord/utils")>]
let private findInTreeRaw (_node: obj) (_filter: obj -> bool) (_opts: option<FindInTreeOptionsRaw>) : obj = jsNative

let private rawifyTreeOptions options : FindInTreeOptionsRaw =
    {walkable = Option.map List.toArray options.walkable
     ignore = Option.map List.toArray options.ignore
     limit = options.limit}

let findInTree node filter options =
    findInTreeRaw node filter (Option.map rawifyTreeOptions options)

[<ImportMember("@cumcord/utils")>]
let getOwnerInstance (_node: obj) : obj = jsNative

[<ImportMember("@cumcord/utils")>]
let getReactInstance (_node: HTMLElement) : obj = jsNative

[<ImportMember("@cumcord/utils")>]
let sleep (_ms: int) : Promise<unit> = jsNative

[<ImportMember("@cumcord/utils")>]
let useNest<'a> (_nest: Nest<'a>) : unit = jsNative

module Logger =
    [<ImportMember("@cumcord/utils/logger")>]
    let log (_val: obj) : unit = jsNative

    [<ImportMember("@cumcord/utils/logger")>]
    let warn (_val: obj) : unit = jsNative

    [<ImportMember("@cumcord/utils/logger")>]
    let error (_val: obj) : unit = jsNative