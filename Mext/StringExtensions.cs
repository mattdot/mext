using System;

namespace Mext
{
	public static class StringExtensions
	{
		public static string FormatWith(this string format, params object[] args)
		{
			return String.Format(format, args);
		}
	}
}