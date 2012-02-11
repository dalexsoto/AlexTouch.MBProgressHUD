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
	[Register("MBProgressHUD", true)]
	public partial class MBProgressHUD : MonoTouch.UIKit.UIView {
		static IntPtr selCustomView = Selector.GetHandle ("customView");
		static IntPtr selSetCustomView_ = Selector.GetHandle ("setCustomView:");
		static IntPtr selMode = Selector.GetHandle ("mode");
		static IntPtr selSetMode_ = Selector.GetHandle ("setMode:");
		static IntPtr selAnimationType = Selector.GetHandle ("animationType");
		static IntPtr selSetAnimationType_ = Selector.GetHandle ("setAnimationType:");
		static IntPtr selLabelText = Selector.GetHandle ("labelText");
		static IntPtr selSetLabelText_ = Selector.GetHandle ("setLabelText:");
		static IntPtr selDetailsLabelText = Selector.GetHandle ("detailsLabelText");
		static IntPtr selSetDetailsLabelText_ = Selector.GetHandle ("setDetailsLabelText:");
		static IntPtr selOpacity = Selector.GetHandle ("opacity");
		static IntPtr selSetOpacity_ = Selector.GetHandle ("setOpacity:");
		static IntPtr selXOffset = Selector.GetHandle ("xOffset");
		static IntPtr selSetXOffset_ = Selector.GetHandle ("setXOffset:");
		static IntPtr selYOffset = Selector.GetHandle ("yOffset");
		static IntPtr selSetYOffset_ = Selector.GetHandle ("setYOffset:");
		static IntPtr selMargin = Selector.GetHandle ("margin");
		static IntPtr selSetMargin_ = Selector.GetHandle ("setMargin:");
		static IntPtr selDimBackground = Selector.GetHandle ("dimBackground");
		static IntPtr selSetDimBackground_ = Selector.GetHandle ("setDimBackground:");
		static IntPtr selGraceTime = Selector.GetHandle ("graceTime");
		static IntPtr selSetGraceTime_ = Selector.GetHandle ("setGraceTime:");
		static IntPtr selMinShowTime = Selector.GetHandle ("minShowTime");
		static IntPtr selSetMinShowTime_ = Selector.GetHandle ("setMinShowTime:");
		static IntPtr selTaskInProgress = Selector.GetHandle ("taskInProgress");
		static IntPtr selSetTaskInProgress_ = Selector.GetHandle ("setTaskInProgress:");
		static IntPtr selRemoveFromSuperViewOnHide = Selector.GetHandle ("removeFromSuperViewOnHide");
		static IntPtr selSetRemoveFromSuperViewOnHide_ = Selector.GetHandle ("setRemoveFromSuperViewOnHide:");
		static IntPtr selLabelFont = Selector.GetHandle ("labelFont");
		static IntPtr selSetLabelFont_ = Selector.GetHandle ("setLabelFont:");
		static IntPtr selDetailsLabelFont = Selector.GetHandle ("detailsLabelFont");
		static IntPtr selSetDetailsLabelFont_ = Selector.GetHandle ("setDetailsLabelFont:");
		static IntPtr selProgress = Selector.GetHandle ("progress");
		static IntPtr selSetProgress_ = Selector.GetHandle ("setProgress:");
		static IntPtr selMinSize = Selector.GetHandle ("minSize");
		static IntPtr selSetMinSize_ = Selector.GetHandle ("setMinSize:");
		static IntPtr selIsSquare = Selector.GetHandle ("isSquare");
		static IntPtr selSetSquare_ = Selector.GetHandle ("setSquare:");
		static IntPtr selDelegate = Selector.GetHandle ("delegate");
		static IntPtr selSetDelegate_ = Selector.GetHandle ("setDelegate:");
		static IntPtr selShowHUDAddedToAnimated_ = Selector.GetHandle ("showHUDAddedTo:animated:");
		static IntPtr selHideHUDForViewAnimated_ = Selector.GetHandle ("hideHUDForView:animated:");
		static IntPtr selInitWithWindow_ = Selector.GetHandle ("initWithWindow:");
		static IntPtr selInitWithView_ = Selector.GetHandle ("initWithView:");
		static IntPtr selShow_ = Selector.GetHandle ("show:");
		static IntPtr selHide_ = Selector.GetHandle ("hide:");
		static IntPtr selHideAfterDelay_ = Selector.GetHandle ("hide:afterDelay:");
		static IntPtr selShowWhileExecutingOnTargetWithObjectAnimated_ = Selector.GetHandle ("showWhileExecuting:onTarget:withObject:animated:");
		
		static IntPtr class_ptr = Class.GetHandle ("MBProgressHUD");
		
		[Export ("init")]
		public  MBProgressHUD () : base (NSObjectFlag.Empty)
		{
			Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.Init);
			
		}

		public MBProgressHUD (NSObjectFlag t) : base (t) {}

		public MBProgressHUD (IntPtr handle) : base (handle) {}

		[Export ("showHUDAddedTo:animated:")]
		public static MBProgressHUD ShowHUDAddedToanimated (MonoTouch.UIKit.UIView view, bool animated)
		{
			if (view == null)
				throw new ArgumentNullException ("view");
			return (MBProgressHUD) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_bool (class_ptr, selShowHUDAddedToAnimated_, view.Handle, animated));
		}
		
		[Export ("hideHUDForView:animated:")]
		public static bool HideHUDForViewanimated (MonoTouch.UIKit.UIView view, bool animated)
		{
			if (view == null)
				throw new ArgumentNullException ("view");
			return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr_bool (class_ptr, selHideHUDForViewAnimated_, view.Handle, animated);
		}
		
		[Export ("initWithWindow:")]
		public MBProgressHUD (MonoTouch.UIKit.UIWindow window) : base (NSObjectFlag.Empty)
		{
			if (window == null)
				throw new ArgumentNullException ("window");
			Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selInitWithWindow_, window.Handle);
		}
		
		[Export ("initWithView:")]
		public MBProgressHUD (MonoTouch.UIKit.UIView view) : base (NSObjectFlag.Empty)
		{
			if (view == null)
				throw new ArgumentNullException ("view");
			Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selInitWithView_, view.Handle);
		}
		
		[Export ("show:")]
		public virtual void Show (bool animated)
		{
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selShow_, animated);
		}
		
		[Export ("hide:")]
		public virtual void Hide (bool animated)
		{
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selHide_, animated);
		}
		
		[Export ("hide:afterDelay:")]
		public virtual void HideafterDelay (bool animated, System.Double delay)
		{
			ApiDefinition.Messaging.void_objc_msgSend_bool_Double (this.Handle, selHideAfterDelay_, animated, delay);
		}
		
		[Export ("showWhileExecuting:onTarget:withObject:animated:")]
		public virtual void ShowWhileExecutingonTargetwithObjectanimated (Selector method, NSObject target, NSObject Object, bool animated)
		{
			if (method == null)
				throw new ArgumentNullException ("method");
			if (target == null)
				throw new ArgumentNullException ("target");
			if (Object == null)
				throw new ArgumentNullException ("Object");
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_bool (this.Handle, selShowWhileExecutingOnTargetWithObjectAnimated_, method.Handle, target.Handle, Object.Handle, animated);
		}
		
		object __mt_CustomView_var;
		public virtual MonoTouch.UIKit.UIView CustomView {
			[Export ("customView", ArgumentSemantic.Retain)]
			get {
				MonoTouch.UIKit.UIView ret;
				ret = (MonoTouch.UIKit.UIView) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selCustomView));
				if (!IsNewRefcountEnabled ())
					__mt_CustomView_var = ret;
				return ret;
			}
			
			[Export ("setCustomView:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetCustomView_, value.Handle);
				if (!IsNewRefcountEnabled ())
					__mt_CustomView_var = value;
			}
		}
		
		public virtual MBProgressHUDMode Mode {
			[Export ("mode", ArgumentSemantic.Assign)]
			get {
				return (MBProgressHUDMode) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selMode);
			}
			
			[Export ("setMode:", ArgumentSemantic.Assign)]
			set {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetMode_, (int)value);
			}
		}
		
		public virtual MBProgressHUDAnimation AnimationType {
			[Export ("animationType", ArgumentSemantic.Assign)]
			get {
				return (MBProgressHUDAnimation) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selAnimationType);
			}
			
			[Export ("setAnimationType:", ArgumentSemantic.Assign)]
			set {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetAnimationType_, (int)value);
			}
		}
		
		public virtual string LabelText {
			[Export ("labelText", ArgumentSemantic.Copy)]
			get {
				return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selLabelText));
			}
			
			[Export ("setLabelText:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = new NSString (value);
				
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetLabelText_, nsvalue.Handle);
				nsvalue.Dispose ();
				
			}
		}
		
		public virtual string DetailsLabelText {
			[Export ("detailsLabelText", ArgumentSemantic.Copy)]
			get {
				return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDetailsLabelText));
			}
			
			[Export ("setDetailsLabelText:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = new NSString (value);
				
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetDetailsLabelText_, nsvalue.Handle);
				nsvalue.Dispose ();
				
			}
		}
		
		public virtual float Opacity {
			[Export ("opacity", ArgumentSemantic.Assign)]
			get {
				return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selOpacity);
			}
			
			[Export ("setOpacity:", ArgumentSemantic.Assign)]
			set {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetOpacity_, value);
			}
		}
		
		public virtual float XOffset {
			[Export ("xOffset", ArgumentSemantic.Assign)]
			get {
				return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selXOffset);
			}
			
			[Export ("setXOffset:", ArgumentSemantic.Assign)]
			set {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetXOffset_, value);
			}
		}
		
		public virtual float YOffset {
			[Export ("yOffset", ArgumentSemantic.Assign)]
			get {
				return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selYOffset);
			}
			
			[Export ("setYOffset:", ArgumentSemantic.Assign)]
			set {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetYOffset_, value);
			}
		}
		
		public virtual float Margin {
			[Export ("margin", ArgumentSemantic.Assign)]
			get {
				return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selMargin);
			}
			
			[Export ("setMargin:", ArgumentSemantic.Assign)]
			set {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetMargin_, value);
			}
		}
		
		public virtual bool DimBackground {
			[Export ("dimBackground", ArgumentSemantic.Assign)]
			get {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selDimBackground);
			}
			
			[Export ("setDimBackground:", ArgumentSemantic.Assign)]
			set {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetDimBackground_, value);
			}
		}
		
		public virtual float GraceTime {
			[Export ("graceTime", ArgumentSemantic.Assign)]
			get {
				return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selGraceTime);
			}
			
			[Export ("setGraceTime:", ArgumentSemantic.Assign)]
			set {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetGraceTime_, value);
			}
		}
		
		public virtual float MinShowTime {
			[Export ("minShowTime", ArgumentSemantic.Assign)]
			get {
				return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selMinShowTime);
			}
			
			[Export ("setMinShowTime:", ArgumentSemantic.Assign)]
			set {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetMinShowTime_, value);
			}
		}
		
		public virtual bool TaskInProgress {
			[Export ("taskInProgress", ArgumentSemantic.Assign)]
			get {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selTaskInProgress);
			}
			
			[Export ("setTaskInProgress:", ArgumentSemantic.Assign)]
			set {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetTaskInProgress_, value);
			}
		}
		
		public virtual bool RemoveFromSuperViewOnHide {
			[Export ("removeFromSuperViewOnHide", ArgumentSemantic.Assign)]
			get {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selRemoveFromSuperViewOnHide);
			}
			
			[Export ("setRemoveFromSuperViewOnHide:", ArgumentSemantic.Assign)]
			set {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetRemoveFromSuperViewOnHide_, value);
			}
		}
		
		object __mt_LabelFont_var;
		public virtual MonoTouch.UIKit.UIFont LabelFont {
			[Export ("labelFont", ArgumentSemantic.Retain)]
			get {
				MonoTouch.UIKit.UIFont ret;
				ret = (MonoTouch.UIKit.UIFont) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selLabelFont));
				if (!IsNewRefcountEnabled ())
					__mt_LabelFont_var = ret;
				return ret;
			}
			
			[Export ("setLabelFont:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetLabelFont_, value.Handle);
				if (!IsNewRefcountEnabled ())
					__mt_LabelFont_var = value;
			}
		}
		
		object __mt_DetailsLabelFont_var;
		public virtual MonoTouch.UIKit.UIFont DetailsLabelFont {
			[Export ("detailsLabelFont", ArgumentSemantic.Retain)]
			get {
				MonoTouch.UIKit.UIFont ret;
				ret = (MonoTouch.UIKit.UIFont) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDetailsLabelFont));
				if (!IsNewRefcountEnabled ())
					__mt_DetailsLabelFont_var = ret;
				return ret;
			}
			
			[Export ("setDetailsLabelFont:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetDetailsLabelFont_, value.Handle);
				if (!IsNewRefcountEnabled ())
					__mt_DetailsLabelFont_var = value;
			}
		}
		
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
		
		public virtual System.Drawing.SizeF MinSize {
			[Export ("minSize", ArgumentSemantic.Assign)]
			get {
				System.Drawing.SizeF ret;
				if (Runtime.Arch == Arch.DEVICE){
					MonoTouch.ObjCRuntime.Messaging.SizeF_objc_msgSend_stret (out ret, this.Handle, selMinSize);
				} else {
					ret = MonoTouch.ObjCRuntime.Messaging.SizeF_objc_msgSend (this.Handle, selMinSize);
				}
				return ret;
			}
			
			[Export ("setMinSize:", ArgumentSemantic.Assign)]
			set {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_SizeF (this.Handle, selSetMinSize_, value);
			}
		}
		
		public virtual bool Square {
			[Export ("isSquare", ArgumentSemantic.Assign)]
			get {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsSquare);
			}
			
			[Export ("setSquare:", ArgumentSemantic.Assign)]
			set {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetSquare_, value);
			}
		}
		
		object __mt_WeakDelegate_var;
		public virtual NSObject WeakDelegate {
			[Export ("delegate", ArgumentSemantic.Assign)]
			get {
				NSObject ret;
				ret = (NSObject) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDelegate));
				MarkDirty ();
				__mt_WeakDelegate_var = ret;
				return ret;
			}
			
			[Export ("setDelegate:", ArgumentSemantic.Assign)]
			set {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetDelegate_, value == null ? IntPtr.Zero : value.Handle);
				MarkDirty ();
				__mt_WeakDelegate_var = value;
			}
		}
		
		public MBProgressHUDDelegate Delegate {
			get { return WeakDelegate as MBProgressHUDDelegate; }
			set { WeakDelegate = value; }
		}
		
		//
		// Events and properties from the delegate
		//
		
		_MBProgressHUDDelegate EnsureMBProgressHUDDelegate ()
		{
			var del = WeakDelegate;
			if (del == null || (!(del is _MBProgressHUDDelegate))){
				del = new _MBProgressHUDDelegate ();
				WeakDelegate = del;
			}
			return (_MBProgressHUDDelegate) del;
		}
		
		[Register]
		class _MBProgressHUDDelegate : AlexTouch.MBProgressHUD.MBProgressHUDDelegate { 
			public _MBProgressHUDDelegate () {}
			
			internal EventHandler wasHidden;
			[Preserve (Conditional = true)]
			public override Void WasHidden (AlexTouch.MBProgressHUD.MBProgressHUD sender)
			{
				if (wasHidden != null){
					wasHidden (sender, EventArgs.Empty);
				}
			}
			
		}
		
		public event EventHandler WasHidden {
			add { EnsureMBProgressHUDDelegate ().wasHidden += value; }
			remove { EnsureMBProgressHUDDelegate ().wasHidden -= value; }
		}
		
		protected override void Dispose (bool disposing)
		{
			__mt_CustomView_var = null;
			__mt_LabelFont_var = null;
			__mt_DetailsLabelFont_var = null;
			__mt_WeakDelegate_var = null;
			base.Dispose (disposing);
		}
	} /* class MBProgressHUD */
}
