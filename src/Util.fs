module Fable.Cumcord.Util

open System.Collections.Generic
open Fable.Core
open Fable.Core.JsInterop

let maybeFallback maybe fallback =
    match maybe with
    | Some x -> x
    | None -> fallback

[<Emit("undefined")>]
let undefined: obj = jsNative

[<Emit("window.DiscordNative !== undefined")>]
let isOnDesktop: bool = jsNative

type NestEventType =
    | SET
    | DELETE
    | UPDATE

type NestEmitData<'a> = { path: string []; value: 'a }

type NestListeners =
    { DELETE: HashSet<JsFunc>
      GET: HashSet<JsFunc>
      SET: HashSet<JsFunc>
      UPDATE: HashSet<JsFunc> }

type Nest<'a> =
    { delete: NestEmitData<obj> -> unit
      emit: NestEventType -> NestEmitData<obj> -> unit
      get: NestEmitData<obj> -> unit
      ghost: 'a
      listeners: NestListeners
      off: NestEventType -> (NestEventType -> NestEmitData<obj> -> unit) -> unit
      on: NestEventType -> (NestEventType -> NestEmitData<obj> -> unit) -> unit
      once: NestEventType -> (NestEventType -> NestEmitData<obj> -> unit) -> unit
      set: NestEmitData<obj> -> unit
      store: 'a
      update: NestEmitData<obj> -> unit }

let nullOrCall func x =
    match x with
    | Some y -> Some(func y)
    | None -> None