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
	[Register("MBProgressHUDDelegate", true)]
	public partial class MBProgressHUDDelegate : NSObject {
		static IntPtr selHudWasHidden_ = Selector.GetHandle ("hudWasHidden:");
		
		static IntPtr class_ptr = Class.GetHandle ("MBProgressHUDDelegate");
		
		[Export ("init")]
		public  MBProgressHUDDelegate () : base (NSObjectFlag.Empty)
		{
			Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.Init);
			
		}

		public MBProgressHUDDelegate (NSObjectFlag t) : base (t) {}

		public MBProgressHUDDelegate (IntPtr handle) : base (handle) {}

		[Export ("hudWasHidden:")]
		public virtual void WasHidden (MBProgressHUD sender)
		{
			if (sender == null)
				throw new ArgumentNullException ("sender");
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selHudWasHidden_, sender.Handle);
		}
		
	} /* class MBProgressHUDDelegate */
}
