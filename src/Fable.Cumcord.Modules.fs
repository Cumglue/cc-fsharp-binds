namespace Fable.Cumcord.Modules

open Fable.Core
open Fable.Core.JsInterop
open Fable.Cumcord.Util

module Webpack =
    [<ImportMember("@cumcord/modules/webpack")>]
    let find: (obj -> bool) -> option<obj> = jsNative
    
    [<ImportMember("@cumcord/modules/webpack")>]
    let findAll: (obj -> bool) -> obj[] = jsNative
    
    [<ImportMember("@cumcord/modules/webpack")>]
    let private findAsyncRaw: (unit -> option<obj>) -> bool -> obj[] = jsNative
    
    let findAsync filter =
        let res = findAsyncRaw filter false
        res[0] :?> Async<obj>, res[1] :?> unit -> unit
    
    [<ImportMember("@cumcord/modules/webpack")>]
    let findByDisplayName: string -> bool -> option<obj> = jsNative
    
    [<ImportMember("@cumcord/modules/webpack")>]
    let findByDisplayNameAll: string -> obj[] = jsNative
    
    [<ImportMember("@cumcord/modules/webpack")>]
    let findByKeywordAll: string -> obj[] = jsNative
    
    [<ImportMember("@cumcord/modules/webpack")>]
    let findByProps: string[] -> option<obj> = jsNative
    
    [<ImportMember("@cumcord/modules/webpack")>]
    let findByPropsAll: string[] -> obj[] = jsNative
    
    [<ImportMember("@cumcord/modules/webpack")>]
    let findByPrototypes: string[] -> option<obj> = jsNative
    
    [<ImportMember("@cumcord/modules/webpack")>]
    let findByStrings: string[] -> option<obj> = jsNative
    
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
        let get: string -> Async<option<obj>> = jsNative
        
        [<ImportMember("@cumcord/modules/internal/idbKeyval")>]
        let set: string -> option<obj> -> Async<unit> = jsNative