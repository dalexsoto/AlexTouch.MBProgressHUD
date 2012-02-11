//
//  StructsAndEnums.cs
//
//
//  Version 1.0
//  Autor: 		Alex Soto.
//	Email: 		alex@alexsoto.me
//	Twitter:	@dalexsoto
//	
//	Revised on: Saturday 11/Feb/2012
//
// 	This code is distributed under the terms and conditions of the MIT license.
//
// 	Copyright (c) 2012 Alex Soto
//
// 	Permission is hereby granted, free of charge, to any person obtaining a copy
// 	of this software and associated documentation files (the "Software"), to deal
// 	in the Software without restriction, including without limitation the rights
// 	to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// 	copies of the Software, and to permit persons to whom the Software is
// 	furnished to do so, subject to the following conditions:
//
// 	The above copyright notice and this permission notice shall be included in
// 	all copies or substantial portions of the Software.
//
// 	THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// 	IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// 	FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// 	AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// 	LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// 	OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// 	THE SOFTWARE.

using System;

namespace AlexTouch.MBProgressHUD
{
	
	public enum MBProgressHUDMode
	{
		/// <summary>
		/// Progress is shown using an UIActivityIndicatorView. This is the default.
		/// </summary>
		Indeterminate,
    
		/// <summary>
		/// Progress is shown using a MBRoundProgressView.
		/// </summary>
		Determinate,
		
		/// <summary>
		/// Shows a custom view
		/// </summary>
		CustomView	
	}
	
	public enum MBProgressHUDAnimation
	{
		/// <summary>
		/// Opacity animation
		/// </summary>
		Fade,
    
		/// <summary>
		/// Opacity + scale animation
		/// </summary>
    	Zoom
	}
	
}

