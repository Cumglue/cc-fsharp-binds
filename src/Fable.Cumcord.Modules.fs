namespace Fable.Cumcord.Modules

open Fable.Core
open Fable.Core.JsInterop
open Fable.Cumcord.Util

module Webpack =
    [<ImportMember("@cumcord/modules/webpack")>]
    let find: (obj -> bool) -> option<obj> = jsNative
    
    [<Import("findAll", from = "@cumcord/modules/webpack")>]
    let private findAllRaw: (obj -> bool) -> obj[] = jsNative
    let findAll = findAllRaw >> Array.toList
    
    [<ImportMember("@cumcord/modules/webpack")>]
    let findAsync: (unit -> option<obj>) -> bool -> (JS.Promise<obj> * unit -> unit) = jsNative
    
    [<ImportMember("@cumcord/modules/webpack")>]
    let findByDisplayName: string -> bool -> option<obj> = jsNative
    
    [<Import("findByDisplayNameAll", from = "@cumcord/modules/webpack")>]
    let private findByDisplayNameAllRaw: string -> obj[] = jsNative
    let findByDisplayNameAll = findByDisplayNameAllRaw >> Array.toList
    
    [<Import("findByKeywordAll", from = "@cumcord/modules/webpack")>]
    let private findByKeywordAllRaw: string -> obj[] = jsNative
    let findByKeywordAll = findByKeywordAllRaw >> Array.toList
    
    [<Import("findByProps", from = "@cumcord/modules/webpack")>]
    let private findByPropsRaw: string[] -> option<obj> = jsNative
    let findByProps = List.toArray >> findByPropsRaw
    
    [<Import("findByPropsAll", from = "@cumcord/modules/webpack")>]
    let private findByPropsAllRaw: string[] -> obj[] = jsNative
    let findByPropsAll = List.toArray >> findByPropsAllRaw >> Array.toList
    
    [<Import("findByPrototypes", from = "@cumcord/modules/webpack")>]
    let private findByPrototypesRaw: string[] -> option<obj> = jsNative
    let findByPrototypes = List.toArray >> findByPrototypesRaw
    
    [<Import("findByStrings", from = "@cumcord/modules/webpack")>]
    let private findByStringsRaw: string[] -> option<obj> = jsNative
    let findByStrings = List.toArray >> findByStringsRaw
    
module Common =
    [<ImportMember("@cumcord/modules/common")>]
    let Flux: obj = jsNative
    
    [<ImportMember("@cumcord/modules/common")>]
    let FluxDispatcher: obj = jsNative
    
    [<ImportMember("@cumcord/modules/common")>]
    let React: obj = jsNative // TODO: Feliz
    
    [<ImportMember("@cumcord/modules/common")>]
    let ReactDOM: obj = jsNative
    
    [<ImportMember("@cumcord/modules/common")>]
    let Redux: obj = jsNative
    
    [<ImportMember("@cumcord/modules/common")>]
    let channels: obj = jsNative
    
    [<ImportMember("@cumcord/modules/common")>]
    let constants: obj = jsNative
    
    [<ImportMember("@cumcord/modules/common")>]
    let highlightjs: obj = jsNative
    
    [<ImportMember("@cumcord/modules/common")>]
    let i18n: obj = jsNative
    
    [<ImportMember("@cumcord/modules/common")>]
    let uuid: obj = jsNative
    
    [<ImportMember("@cumcord/modules/common")>]
    let zustand: JsFunc = jsNative
    
module Internal =
    module Nests =
        [<ImportMember("@cumcord/modules/internal/nests")>]
        let make<'a> : 'a -> Nest<'a> = jsNative
        
        type EventsType = {
            DELETE: string
            GET: string
            SET: string
            UPDATE: string
        }
        
        [<ImportMember("@cumcord/modules/internal/nests")>]
        let Events: EventsType = jsNative
    
    module IdbKeyval =
        [<ImportMember("@cumcord/modules/internal/idbKeyval")>]
        let get: string -> JS.Promise<option<obj>> = jsNative
        
        [<ImportMember("@cumcord/modules/internal/idbKeyval")>]
        let set: string -> option<obj> -> JS.Promise<unit> = jsNative