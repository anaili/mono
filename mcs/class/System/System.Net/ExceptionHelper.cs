using System;

namespace System.Net
{
	internal static class ExceptionHelper
	{
		//
		// Static Properties
		//
		internal static NotImplementedException MethodNotImplementedException {
			get;
		}

		internal static NotSupportedException MethodNotSupportedException {
			get;
		}

		internal static NotImplementedException PropertyNotImplementedException {
			get;
		}

		internal static NotSupportedException PropertyNotSupportedException {
			get;
		}
	}
}
