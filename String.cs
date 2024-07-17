using System;

namespace Unit2{
	class StringType{
		static void Main(string[] args){
			string str1 = "Sangam";
			String str2 = "Subedi";
			Console.WriteLine(str1.GetType().FullName);
			Console.WriteLine(str2.GetType().FullName);
		}
	}
}
