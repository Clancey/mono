
using System;
using System.Threading;
using System.ComponentModel;

namespace System.Windows.Forms {
	public partial class Timer	{
		

		public Timer ()
		{
			enabled = false;
		}

		[DefaultValue (false)]
		public virtual bool Enabled {
			get {
				return enabled;
			}
			set {
				if (value != enabled) {
					enabled = value;
					if (value) {
						// Use AddTicks so we get some rounding
						expires = DateTime.UtcNow.AddMilliseconds (interval > Minimum ? interval : Minimum);

						thread = Thread.CurrentThread;
						XplatUI.SetTimer (this);
					} else {
						XplatUI.KillTimer (this);
						thread = null;
					}
				}
			}
		}
		
		[DefaultValue (100)]
		public int Interval {
			get {
				return interval;
			}
			set {
				if (value <= 0)
#if NET_2_0
					throw new ArgumentOutOfRangeException ("Interval", string.Format ("'{0}' is not a valid value for Interval. Interval must be greater than 0.", value));
#else				
					throw new ArgumentException (string.Format("'{0}' is not a valid value for Interval. Interval must be greater than 0.", value));
#endif					

				if (interval == value) {
					return;
				}
				
				interval = value;
								
				// Use AddTicks so we get some rounding
				expires = DateTime.UtcNow.AddMilliseconds (interval > Minimum ? interval : Minimum);
									
				if (enabled == true) {				
					XplatUI.KillTimer (this);
					XplatUI.SetTimer (this);
				}
			}
		}
	}
}

