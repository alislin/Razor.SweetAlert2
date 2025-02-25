﻿using System.Collections.Generic;

namespace CurrieTechnologies.Razor.SweetAlert2
{
    public class SweetAlertOptions
    {
        public SweetAlertOptions()
        {
        }

        public SweetAlertOptions(string title)
        {
            Title = title;
        }

        /// <summary>
        ///     The title of the modal, as HTML.
        ///     <para>
        ///         It can either be added to the object under the key "title" or passed as the first parameter of
        ///         Swal.FireAsync()
        ///     </para>
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        ///     The title of the popup, as text. Useful to avoid HTML injection.
        /// </summary>
        public string TitleText { get; set; }

        /// <summary>
        ///     A description for the modal.
        ///     <para>If "Text" and "Html" parameters are provided in the same time, "Text" will be used.</para>
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        ///     A HTML description for the modal.
        ///     <para>
        ///         It can either be added to the object under the key "Html" or passed as the second parameter of
        ///         Swal.FireAsync()
        ///     </para>
        /// </summary>
        public string Html { get; set; }

        /// <summary>
        ///     The footer of the modal, as HTML.
        /// </summary>
        public string Footer { get; set; }

        /// <summary>
        ///     The icon of the modal.
        ///     <para>SweetAlert2 comes with 5 built-in icons which will show a corresponding icon animation:</para>
        ///     <para>'warning', 'error', 'success', 'info' and 'question'.</para>
        ///     <para>It can either be put to the object under the key "icon" or passed as the third parameter of Swal.FireAsync().</para>
        /// </summary>
        public SweetAlertIcon Icon { get; set; }

        /// <summary>
        ///     Use this to change the color of the icon.
        /// </summary>
        public string IconColor { get; set; }

        /// <summary>
        ///     The custom HTML content for an icon.
        ///     <para>
        ///         <example>
        ///             ex.
        ///             <code>
        /// Swal.FireAsync(new SweetAlertOptions {
        ///    Icon = SweetAlertIcon.Error,
        ///    IconHtml = "&lt;i class=\"fas fa-bug\"&gt;&lt;/i&gt;"
        /// })
        /// </code>
        ///         </example>
        ///     </para>
        /// </summary>
        public string IconHtml { get; set; }

        /// <summary>
        ///     Whether or not SweetAlert2 should show a full screen click-to-dismiss backdrop.
        /// </summary>
        public bool? Backdrop { get; set; }

        /// <summary>
        ///     Whether or not an alert should be treated as a toast notification.
        ///     <para>This option is normally coupled with the `position` parameter and a timer.</para>
        ///     <para>Toasts are NEVER autofocused.</para>
        /// </summary>
        public bool? Toast { get; set; }

        /// <summary>
        ///     The container element for adding modal into (query selector only).
        /// </summary>
        public string Target { get; set; }

        /// <summary>
        ///     Input field type, can be text, email, password, number, tel, range, textarea, select, radio, checkbox, file and
        ///     url.
        /// </summary>
        public SweetAlertInputType Input { get; set; }

        /// <summary>
        ///     Modal window width, including paddings (box-sizing: border-box). Can be in px or %.
        /// </summary>
        public string Width { get; set; }

        /// <summary>
        ///     Modal window padding.
        /// </summary>
        public string Padding { get; set; }

        /// <summary>
        ///     Popup color for title, content and footer (CSS `color` property).
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        ///     Modal window background (CSS background property).
        /// </summary>
        public string Background { get; set; }

        /// <summary>
        ///     Modal window position.
        /// </summary>
        public SweetAlertPosition Position { get; set; }

        /// <summary>
        ///     Modal window grow direction.
        /// </summary>
        public SweetAlertGrowDirection Grow { get; set; }

        /// <summary>
        ///     CSS classes for animations when showing a popup (fade in)
        /// </summary>
        public SweetAlertShowClass ShowClass { get; set; }

        /// <summary>
        ///     CSS classes for animations when hiding a popup (fade out)
        /// </summary>
        public SweetAlertHideClass HideClass { get; set; }

        /// <summary>
        ///     A custom CSS class for the modal.
        ///     <para>If a string value is provided, the classname will be applied to the popup.</para>
        ///     <para></para>
        /// </summary>
        public SweetAlertCustomClass CustomClass { get; set; }

        /// <summary>
        ///     Auto close timer of the modal. Set in ms (milliseconds).
        /// </summary>
        public decimal? Timer { get; set; }

        /// <summary>
        ///     If set to true, the timer will have a progress bar at the bottom of a popup.
        ///     <para>Mostly, this feature is useful with toasts.</para>
        /// </summary>
        public bool? TimerProgressBar { get; set; }

        /// <summary>
        ///     By default, SweetAlert2 sets html's and body's CSS height to auto !important.
        ///     <para>If this behavior isn't compatible with your project's layout, set heightAuto to false.</para>
        /// </summary>
        public bool? HeightAuto { get; set; }

        /// <summary>
        ///     If set to false, the user can't dismiss the modal by clicking outside it.
        /// </summary>
        public bool? AllowOutsideClick { get; set; }

        /// <summary>
        ///     If set to false, the user can't dismiss the modal by pressing the Escape key.
        /// </summary>
        public bool? AllowEscapeKey { get; set; }

        /// <summary>
        ///     If set to false, the user can't confirm the modal by pressing the Enter or Space keys, unless they manually focus
        ///     the confirm button.
        /// </summary>
        public bool? AllowEnterKey { get; set; }

        /// <summary>
        ///     If set to false, SweetAlert2 will allow keydown events propagation to the document.
        /// </summary>
        public bool? StopKeydownPropagation { get; set; }

        /// <summary>
        ///     Useful for those who are using SweetAlert2 along with Bootstrap modals.
        ///     <para>
        ///         By default keydownListenerCapture is false which means when a user hits Esc, both SweetAlert2 and Bootstrap
        ///         modals will be closed.
        ///     </para>
        ///     <para>Set keydownListenerCapture to true to fix that behavior.</para>
        /// </summary>
        public bool? KeydownListenerCapture { get; set; }

        /// <summary>
        ///     If set to false, a "Confirm" button will not be shown.
        ///     <para>It can be useful when you're using custom HTML description.</para>
        /// </summary>
        public bool? ShowConfirmButton { get; set; }

        /// <summary>
        ///     If set to true, the "Deny" button will be shown, which the user can click on to deny the popup.
        /// </summary>
        public bool? ShowDenyButton { get; set; }

        /// <summary>
        ///     If set to true, a "Cancel" button will be shown, which the user can click on to dismiss the modal.
        /// </summary>
        public bool? ShowCancelButton { get; set; }

        /// <summary>
        ///     Use this to change the text on the "Confirm" button.
        /// </summary>
        public string ConfirmButtonText { get; set; }

        /// <summary>
        ///     Use this to change the text on the "Deny" button.
        /// </summary>
        public string DenyButtonText { get; set; }

        /// <summary>
        ///     Use this to change the text on the "Cancel" button.
        /// </summary>
        public string CancelButtonText { get; set; }

        /// <summary>
        ///     Use this to change the background color of the "Confirm" button.
        /// </summary>
        public string ConfirmButtonColor { get; set; }

        /// <summary>
        ///     Use this to change the background color of the "Deny" button.
        /// </summary>
        public string DenyButtonColor { get; set; }

        /// <summary>
        ///     Use this to change the background color of the "Cancel" button.
        /// </summary>
        public string CancelButtonColor { get; set; }

        /// <summary>
        ///     Use this to change the aria-label for the "Confirm" button.
        /// </summary>
        public string ConfirmButtonAriaLabel { get; set; }

        /// <summary>
        ///     Use this to change the aria-label for the "Deny" button.
        /// </summary>
        public string DenyButtonAriaLabel { get; set; }

        /// <summary>
        ///     Use this to change the aria-label for the "Cancel" button.
        /// </summary>
        public string CancelButtonAriaLabel { get; set; }

        /// <summary>
        ///     Whether to apply the default SweetAlert2 styling to buttons.
        ///     <para>If you want to use your own classes (e.g. Bootstrap classes) set this parameter to false.</para>
        /// </summary>
        public bool? ButtonsStyling { get; set; }

        /// <summary>
        ///     Set to true if you want to invert default buttons positions.
        /// </summary>
        public bool? ReverseButtons { get; set; }

        /// <summary>
        ///     Set to false if you want to focus the first element in tab order instead of "Confirm" button by default.
        /// </summary>
        public bool? FocusConfirm { get; set; }

        /// <summary>
        ///     Set to true if you want to focus the "Deny" button by default.
        /// </summary>
        public bool? FocusDeny { get; set; }

        /// <summary>
        ///     Set to true if you want to focus the "Cancel" button by default.
        /// </summary>
        public bool? FocusCancel { get; set; }

        /// <summary>
        ///     Set to false if you don't want to return the focus to the element that invoked the modal after the modal is closed.
        /// </summary>
        public bool? ReturnFocus { get; set; }

        /// <summary>
        ///     Set to true to show close button in top right corner of the modal.
        /// </summary>
        public bool? ShowCloseButton { get; set; }

        /// <summary>
        ///     Use this to change the content of the close button.
        /// </summary>
        public string CloseButtonHtml { get; set; }

        /// <summary>
        ///     Use this to change the `aria-label` for the close button.
        /// </summary>
        public string CloseButtonAriaLabel { get; set; }

        /// <summary>
        ///     Use this to change the HTML content of the loader.
        /// </summary>
        public string LoaderHtml { get; set; }

        /// <summary>
        ///     Set to true to disable buttons and show the loader instead of the Confirm button
        /// </summary>
        public bool? ShowLoaderOnConfirm { get; set; }

        /// <summary>
        ///     Set to true to disable buttons and show the loader instead of the Deny button.
        /// </summary>
        public bool? ShowLoaderOnDeny { get; set; }

        /// <summary>
        ///     Function to execute before confirming, may be async or sync.
        ///     <para> Returned (or resolved) value can be:</para>
        ///     <para>"false" to prevent a popup from closing</para>
        ///     <para>anything else to pass that value as the `Result.Value` of `Swal.FireAsync()`</para>
        ///     <para>`null` to keep the default `Result.Value`</para>
        /// </summary>
        public PreConfirmCallback PreConfirm { get; set; }

        /// <summary>
        ///     Function to execute before denying, may be async or sync.
        ///     <para> Returned (or resolved) value can be:</para>
        ///     <para>"false" to prevent a popup from closing</para>
        ///     <para>anything else to pass that value as the `Result.Value` of `Swal.FireAsync()`</para>
        ///     <para>`null` to keep the default `Result.Value`</para>
        /// </summary>
        public PreDenyCallback PreDeny { get; set; }

#pragma warning disable CA1056 // Uri properties should not be strings
        /// <summary>
        ///     Add an image to the popup. Should contain a string with the path or URL to the image.
        /// </summary>
        public string ImageUrl { get; set; }
#pragma warning restore CA1056 // Uri properties should not be strings

        /// <summary>
        ///     If imageUrl is set, you can specify imageWidth to describes image width.
        /// </summary>
        public double? ImageWidth { get; set; }

        /// <summary>
        ///     If imageUrl is set, you can specify imageHeight to describes image height.
        /// </summary>
        public double? ImageHeight { get; set; }

        /// <summary>
        ///     An alternative text for the custom image icon.
        /// </summary>
        public string ImageAlt { get; set; }

        /// <summary>
        ///     Input field label.
        /// </summary>
        public string InputLabel { get; set; }

        /// <summary>
        ///     Input field placeholder.
        /// </summary>
        public string InputPlaceholder { get; set; }

        /// <summary>
        ///     Input field initial value.
        /// </summary>
        public string InputValue { get; set; }

#pragma warning disable CA2227 // Collection properties should be read only
        /// <summary>
        ///     If input parameter is set to "select" or "radio", you can provide options.
        ///     <para>Object keys will represent options values, object values will represent options text values.</para>
        /// </summary>
        public IDictionary<string, string> InputOptions { get; set; }
#pragma warning restore CA2227 // Collection properties should be read only

        /// <summary>
        ///     Automatically remove whitespaces from both ends of a result string.
        ///     <para>Set this parameter to false to disable auto-trimming.</para>
        /// </summary>
        public bool? InputAutoTrim { get; set; }

        //TODO: Input Attributes POCO
#pragma warning disable CA2227 // Collection properties should be read only
        /// <summary>
        ///     HTML input attributes (e.g. min, max, step, accept...), that are added to the input field.
        /// </summary>
        public IDictionary<string, string> InputAttributes { get; set; }
#pragma warning restore CA2227 // Collection properties should be read only

        /// <summary>
        ///     Validator for input field.
        /// </summary>
        public InputValidatorCallback InputValidator { get; set; }

        /// <summary>
        ///     If you want to return the input value as `Result.Value` when denying the popup, set to `true`.
        ///     Otherwise, the denying will set `Result.Value` to `false`.
        /// </summary>
        public bool? ReturnInputValueOnDeny { get; set; }

        /// <summary>
        ///     A custom validation message for default validators (email, url).
        /// </summary>
        public string ValidationMessage { get; set; }

        /// <summary>
        ///     Progress steps, useful for popup queues.
        /// </summary>
        public IEnumerable<string> ProgressSteps { get; set; }

        /// <summary>
        ///     Current active progress step.
        /// </summary>
        public string CurrentProgressStep { get; set; }

        /// <summary>
        ///     Distance between progress steps.
        /// </summary>
        public string ProgressStepsDistance { get; set; }

        /// <summary>
        ///     Popup lifecycle hook. Synchronously runs before the popup is shown on screen.
        /// </summary>
        public SweetAlertCallback WillOpen { get; set; }

        /// <summary>
        ///     Popup lifecycle hook. Asynchronously runs after the popup has been disposed by user interaction (and not due to
        ///     another popup being fired).
        /// </summary>
        public SweetAlertCallback DidClose { get; set; }

        /// <summary>
        ///     Popup lifecycle hook. Synchronously runs after popup has been destroyed either by user interaction or by another
        ///     popup.
        ///     <para>
        ///         If you have cleanup operations that you need to reliably execute each time a popup is closed, prefer
        ///         `DidDestroy` over `DidClose`
        ///     </para>
        /// </summary>
        public SweetAlertCallback DidDestroy { get; set; }

        /// <summary>
        ///     Popup lifecycle hook. Asynchronously runs after the popup has been shown on screen.
        /// </summary>
        public SweetAlertCallback DidOpen { get; set; }

        /// <summary>
        ///     Popup lifecycle hook. Synchronously runs when the popup closes by user interaction (and not due to another popup
        ///     being fired).
        /// </summary>
        public SweetAlertCallback WillClose { get; set; }

        /// <summary>
        ///     Popup lifecycle hook. Synchronously runs after the popup DOM has been updated (ie. just before the popup is
        ///     repainted on the screen).
        ///     <para>Typically, this will happen after Swal.FireAsync() or Swal.UpdateAsync().</para>
        ///     <para>
        ///         If you want to perform changes in the modal's DOM, that survive Swal.UpdateAsync(), prefer `DidRender` over
        ///         `WillOpen`
        ///     </para>
        /// </summary>
        public SweetAlertCallback DidRender { get; set; }

        /// <summary>
        ///     Set to false to disable body padding adjustment when scrollbar is present.
        /// </summary>
        public bool? ScrollbarPadding { get; set; }

        internal SweetAlertOptionPOCO ToPOCO()
        {
            return new SweetAlertOptionPOCO
            {
                Title = Title,
                TitleText = TitleText,
                Text = Text,
                Html = Html,
                Footer = Footer,
                Icon = Icon?.ToString(),
                IconColor = IconColor,
                IconHtml = IconHtml,
                Backdrop = Backdrop,
                Toast = Toast,
                Target = Target,
                Input = Input?.ToString(),
                Width = Width,
                Padding = Padding,
                Color = Color,
                Background = Background,
                Position = Position?.ToString(),
                Grow = Grow?.ToString(),
                ShowClass = ShowClass,
                HideClass = HideClass,
                CustomClass = CustomClass,
                Timer = Timer,
                TimerProgressBar = TimerProgressBar,
                HeightAuto = HeightAuto,
                AllowOutsideClick = AllowOutsideClick,
                AllowEscapeKey = AllowEscapeKey,
                AllowEnterKey = AllowEnterKey,
                StopKeydownPropagation = StopKeydownPropagation,
                KeydownListenerCapture = KeydownListenerCapture,
                ShowConfirmButton = ShowConfirmButton,
                ShowDenyButton = ShowDenyButton,
                ShowCancelButton = ShowCancelButton,
                ConfirmButtonText = ConfirmButtonText,
                DenyButtonText = DenyButtonText,
                CancelButtonText = CancelButtonText,
                ConfirmButtonColor = ConfirmButtonColor,
                DenyButtonColor = DenyButtonColor,
                CancelButtonColor = CancelButtonColor,
                ConfirmButtonAriaLabel = ConfirmButtonAriaLabel,
                DenyButtonAriaLabel = DenyButtonAriaLabel,
                CancelButtonAriaLabel = CancelButtonAriaLabel,
                ButtonsStyling = ButtonsStyling,
                ReverseButtons = ReverseButtons,
                FocusConfirm = FocusConfirm,
                FocusDeny = FocusDeny,
                FocusCancel = FocusCancel,
                ReturnFocus = ReturnFocus,
                ShowCloseButton = ShowCloseButton,
                CloseButtonHtml = CloseButtonHtml,
                CloseButtonAriaLabel = CloseButtonAriaLabel,
                LoaderHtml = LoaderHtml,
                ShowLoaderOnConfirm = ShowLoaderOnConfirm,
                ShowLoaderOnDeny = ShowLoaderOnDeny,
                PreConfirm = PreConfirm != null,
                PreDeny = PreDeny != null,
                ImageUrl = ImageUrl,
                ImageWidth = ImageWidth,
                ImageHeight = ImageHeight,
                ImageAlt = ImageAlt,
                InputLabel = InputLabel,
                InputPlaceholder = InputPlaceholder,
                InputValue = InputValue,
                InputOptions = InputOptions,
                InputAutoTrim = InputAutoTrim,
                InputAttributes = InputAttributes,
                InputValidator = InputValidator != null,
                ReturnInputValueOnDeny = ReturnInputValueOnDeny,
                ValidationMessage = ValidationMessage,
                ProgressSteps = ProgressSteps,
                CurrentProgressStep = CurrentProgressStep,
                ProgressStepsDistance = ProgressStepsDistance,
                WillOpen = WillOpen != null,
                DidClose = DidClose != null,
                DidDestroy = DidDestroy != null,
                DidOpen = DidOpen != null,
                WillClose = WillClose != null,
                DidRender = DidRender != null,
                ScrollbarPadding = ScrollbarPadding
            };
        }
    }
}