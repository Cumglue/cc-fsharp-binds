namespace Fable.Cumcord.Ui

open Fable.Core
open Fable.Core.JS
open Fable.Core.JsInterop

module Components =
    [<ImportMember("@cumcord/ui/components")>]
    let ErrorBoundary: JsConstructor = jsNative
    
module Modals =
    type ConfirmationModalOptions = {
        header: option<string>
        confirmText: option<string>
        cancelText: option<string>
        content: option<string>
    }
    
    [<ImportMember("@cumcord/ui/modals")>]
    let showConfirmationModal: ConfirmationModalOptions -> Promise<bool> = jsNative

module Toasts =
    type ToastOptions = {
        title: option<string>
        content: option<string>
        onClick: option<unit -> unit>
        className: option<string>
        duration: option<int>
    }
    
    [<ImportMember("@cumcord/ui/toasts")>]
    let showToast: ToastOptions -> unit = jsNative