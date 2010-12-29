// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//
// Copyright (c) 2004 Novell, Inc.
//
// Authors:
//	Peter Bartok	pbartok@novell.com
//
//


using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Runtime.InteropServices;

namespace System.Windows.Forms
{
	public partial class ContainerControl
	{
		#region Public Instance Methods
		#if NET_2_0
		[Browsable (false)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public SizeF CurrentAutoScaleDimensions {
			get {
				switch(auto_scale_mode) {
					case AutoScaleMode.Dpi:
						return TextRenderer.GetDpi ();

					case AutoScaleMode.Font:
						Size s = TextRenderer.MeasureText ("ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890", Font);
						int width = (int)Math.Round ((float)s.Width / 62f);
						
						return new SizeF (width, s.Height);
				}

				return auto_scale_dimensions;
			}
		}
#endif
		

		internal void SendControlFocus (Control c)
		{
			if (c.IsHandleCreated) {
				XplatUI.SetFocus (c.window.Handle);
			}
		}
		#endregion
		
		#region Protected Instance Methods
		protected override CreateParams CreateParams {
			get {
				return base.CreateParams;
			}
		}
			[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected override void WndProc(ref Message m) {
			switch ((Msg) m.Msg) {

				case Msg.WM_SETFOCUS:
					if (active_control != null)
						Select (active_control);
					else
						base.WndProc (ref m);
#if false
					else
						SelectNextControl (null, true, true, true, false);
#endif
				break;

				default:
					base.WndProc(ref m);
					break;
			}
		}
		

#if NET_2_0
		protected override bool ProcessCmdKey (ref Message msg, Keys keyData)
		{
			if (ToolStripManager.ProcessCmdKey (ref msg, keyData) == true)
				return true;
				
			return base.ProcessCmdKey (ref msg, keyData);
		}
#endif

		#endregion	// Protected Instance Methods
	}
}

