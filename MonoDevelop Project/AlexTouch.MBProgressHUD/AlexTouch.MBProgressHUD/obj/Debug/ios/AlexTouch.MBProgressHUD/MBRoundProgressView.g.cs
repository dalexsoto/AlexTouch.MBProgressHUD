//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;

using System.Drawing;

using System.Runtime.InteropServices;

using MonoTouch;

using MonoTouch.CoreFoundation;

using MonoTouch.CoreMedia;

using MonoTouch.CoreMotion;

using MonoTouch.Foundation;

using MonoTouch.ObjCRuntime;

using MonoTouch.CoreAnimation;

using MonoTouch.CoreLocation;

using MonoTouch.MapKit;

using MonoTouch.UIKit;

using MonoTouch.CoreGraphics;

using MonoTouch.NewsstandKit;

using MonoTouch.GLKit;

using OpenTK;

namespace AlexTouch.MBProgressHUD {
	[Register("MBRoundProgressView", true)]
	public partial class MBRoundProgressView : MonoTouch.UIKit.UIView {
		static IntPtr selProgress = Selector.GetHandle ("progress");
		static IntPtr selSetProgress_ = Selector.GetHandle ("setProgress:");
		
		static IntPtr class_ptr = Class.GetHandle ("MBRoundProgressView");
		
		[Export ("init")]
		public  MBRoundProgressView () : base (NSObjectFlag.Empty)
		{
			Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.Init);
			
		}

		public MBRoundProgressView (NSObjectFlag t) : base (t) {}

		public MBRoundProgressView (IntPtr handle) : base (handle) {}

		public virtual float Progress {
			[Export ("progress", ArgumentSemantic.Assign)]
			get {
				return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selProgress);
			}
			
			[Export ("setProgress:", ArgumentSemantic.Assign)]
			set {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetProgress_, value);
			}
		}
		
	} /* class MBRoundProgressView */
}
