using System;
using System.Xml;

namespace Mext
{
	public static class XmlExtensions
	{
		/// <summary>
		/// Gets the value of the specified node or returns the default value if the node is null or can't convert the value to T.
		/// </summary>
		/// <param name='node'>
		/// Node.
		/// </param>
		/// <param name='defaultValue'>
		/// Default value.
		/// </param>
		/// <typeparam name='T'>
		/// The 1st type parameter.
		/// </typeparam>
		public static T SafeValue<T>(this XmlNode node, T defaultValue = default(T))
		{
			if (null == node || null == node.Value) {
				return defaultValue;
			}
			
			var val = node.Value;
			
			if (typeof(T) == typeof(string)) {
				return (T)(object)val;
			}
			
			return (T)Convert.ChangeType (val, typeof(T));
		}
	}
}

