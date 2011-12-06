using System;
using NUnit.Framework;
using Mext;

namespace Mext.Tests
{
	[TestFixture()]
	public class JsonTests
	{
		[Test()]
		public void TestToJson ()
		{
			var obj = new JsonTestClass
			{
				PropStr = "Foo Bar",
				PropInt = 24,
				PropFloat = 1234.1243f,
				PropDate = DateTime.UtcNow
			};
			
			var json = obj.ToJson();
			
			var obj2 = json.ParseJson<JsonTestClass>();
			
			Assert.Equals(obj, obj2);
		}
	}
	
	public class JsonTestClass
	{
		public string PropStr { get; set; }
		public int PropInt { get; set; }
		public DateTime PropDate { get; set; }
		public float PropFloat {
			get;
			set;
		}
		
		public override bool Equals (object obj)
		{
			var jobj = obj as JsonTestClass;
			if(null == jobj)
			{
				return false;
			}
			
			return (this.PropDate.ToString () == jobj.PropDate.ToString ())
				&& (this.PropFloat == jobj.PropFloat)
				&& (this.PropInt == jobj.PropInt)
				&& (this.PropStr == jobj.PropStr);
		}
		
		public override int GetHashCode ()
		{
			return base.GetHashCode ();
		}
	}
}

