using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
namespace CSharpLogic
{
    public class LINQTest
    {
        public LINQTest()
        {
			
        }

		public static void Test(){
			string[] vs = { "samir", "sunita", "ram" };
			IEnumerable<string> filter = System.Linq.Enumerable.Where(vs, n => n.Length >= 4);
			foreach(var t in filter){
				WriteLine(t);
			}
		}
    }
}
