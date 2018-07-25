using System;
using System.Text;

namespace CSharpLogic
{
    public class DataFile
    {
        public DataFile()
        {
        }
		public static string GetSampleData(){
			StringBuilder bldr = new StringBuilder();
			for (int i = 0; i < 1000000;i++){
				bldr.Append(sampleData);
			}
			return bldr.ToString();
		}
		private static string sampleData = "The quick brown fox jumps over the lazy dog The quick brown fox jumps over the lazy dog";
    }
}
