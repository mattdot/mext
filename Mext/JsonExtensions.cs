using System;
using System.Web.Script.Serialization;

namespace Mext
{
	public static class JsonExtensions
	{		
		public static string ToJson(this object obj)
		{
			if(null == obj)
			{
				return null;
			}
			
			JavaScriptSerializer jss = new JavaScriptSerializer();
			return jss.Serialize (obj);
		}
		
		public static T ParseJson<T>(this string json)
		{
			if (String.IsNullOrWhiteSpace(json)) {
				return default(T);
			}
			
			var jss = new JavaScriptSerializer();
			return jss.Deserialize<T>(json);
		}
	}
}

