// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace AVFoundationPlayer
{
	[Register ("AVFPlayer")]
	partial class AVFPlayer
	{
		[Outlet]
		AppKit.NSButton _buttonPlayPause { get; set; }

		[Outlet]
		AppKit.NSButton _buttonStop { get; set; }

		[Outlet]
		AppKit.NSView _customView { get; set; }

		[Outlet]
		AppKit.NSTextField _labelPosition { get; set; }

		[Outlet]
		AppKit.NSSlider _positionSlider { get; set; }

		[Outlet]
		WebKit.WebView _subtitleWebView { get; set; }

		[Outlet]
		AppKit.NSSlider _volumeSlider { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (_customView != null) {
				_customView.Dispose ();
				_customView = null;
			}

			if (_buttonPlayPause != null) {
				_buttonPlayPause.Dispose ();
				_buttonPlayPause = null;
			}

			if (_buttonStop != null) {
				_buttonStop.Dispose ();
				_buttonStop = null;
			}

			if (_positionSlider != null) {
				_positionSlider.Dispose ();
				_positionSlider = null;
			}

			if (_volumeSlider != null) {
				_volumeSlider.Dispose ();
				_volumeSlider = null;
			}

			if (_labelPosition != null) {
				_labelPosition.Dispose ();
				_labelPosition = null;
			}

			if (_subtitleWebView != null) {
				_subtitleWebView.Dispose ();
				_subtitleWebView = null;
			}
		}
	}
}
