module Fable.Cumcord.Dev

open Fable.Core
open Fable.Cumcord.Util

type private DevContents =
    {isEnabled: bool
     showSettings: unit -> unit
     storage: obj
     toggleDevMode: unit -> unit}

[<ImportDefault("@cumcord/dev")>]
let private dev: DevContents = jsNative

let isEnabled =
    if isOnDesktop then
        Some(dev.isEnabled)
    else
        None

let showSettings =
    if isOnDesktop then
        Some(dev.showSettings)
    else
        None

let storage =
    if isOnDesktop then
        Some(dev.storage)
    else
        None

let toggleDevMode =
    if isOnDesktop then
        Some(dev.toggleDevMode)
    else
        None