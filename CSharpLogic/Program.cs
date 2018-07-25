using System;
using System.Text;
using System.Text.RegularExpressions;

namespace CSharpLogic
{
	class Program
	{
	      

		static void Main(string[] args)
		{
			int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
			//ReverseArray(array);

			//Console.WriteLine("Array before reversing:");
			//foreach(int a in array){
			//	Console.Write($"{a}, ");
			//}
			//Console.WriteLine("Array after reversing:");
			//foreach (int a in ReverseArray(array))
			//{
			//    Console.Write($"{a}, ");
			//}


			var str = DataFile.GetSampleData();
			Console.WriteLine($"Length of string is:{str.Length}");
			//Console.WriteLine($"Before reversing {str}");
			var watch = System.Diagnostics.Stopwatch.StartNew();
            // the code that you want to measure comes here
            
			var output = ReverseString(str);
			watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
			//Console.WriteLine($"After reversing {output}");
			Console.WriteLine($"Time taken: {elapsedMs}");
		
			Console.ReadLine();


		}

		#region Reverse a String
		private static string ReverseString(string input){
			StringBuilder bldr = new StringBuilder();
			for (int i = input.Length-1; i >=0;i--){
				bldr.Append(input.Substring(i, 1));
			}
			return bldr.ToString();
		}

		public static string ReverseString1(string input){
			char[] chArray = input.ToCharArray();
			Array.Reverse(chArray);         
			return new string(chArray);
		}
		private static string ReverseString2(string input)
        {
            StringBuilder bldr = new StringBuilder();
			for (int i = 0; i<input.Length; i++)
            {
                bldr.Append(input.Substring(i, 1));
            }
            return bldr.ToString();
        }
		#endregion

		#region Reverse an Array

		private static int[] ReverseArray(int[] arr)
        {
			if (arr.Length <= 0)
				return arr;

            for (int i = 0; i < arr.Length / 2; i++)
            {
                var tmp = arr[i];
				var swapIndex = arr.Length - i - 1;
				arr[i] = arr[swapIndex];
				arr[swapIndex] = tmp;
            }
            return arr;
        } 

		/// <summary>
		/// Reverses the array.
		/// </summary>
		/// <returns>The array.</returns>
		/// <param name="array">Array.</param>
		private static int[] ReverseArray1(int[] array)
		{

			foreach (int a in array)
			{
				Console.WriteLine(a);
			}
			Array.Reverse(array);
			Console.WriteLine("Reversed Array : ");
			foreach (int value in array)
			{
				Console.WriteLine(value);
			}
			Console.ReadLine();
			return array;
		}
		#endregion

		#region Regular Expression

		/// <summary>
        /// Checks the name of the user.
        /// </summary>
        /// <returns><c>true</c>, if user name was checked, <c>false</c> otherwise.</returns>
        /// <param name="userName">User name.</param>
        private static bool CheckUserName(string userName)
        {
            string pattern = @"^([A-Z][a-zA-Z0-9]*)[$]([A-Z][a-zA-Z0-9]*[0-9]{0,3})$";
            return Regex.IsMatch(userName, pattern);

        }
		#endregion

		#region Character Frequency

		/// <summary>
		/// Characters the frequency.
		/// </summary>
		/// <returns>The frequency.</returns>
		/// <param name="input">Input.</param>
		private static string CharacterFrequency(string input)
		{
			if (string.IsNullOrEmpty(input))
				return "";
			var charArray = input.ToLower().ToCharArray();
			Array.Sort(charArray);
			StringBuilder builder = new StringBuilder();
			for (int i = 0; i < charArray.Length; i++)
			{
				int count = 1;
				int index = i;
				while (index + 1 < charArray.Length && charArray[i] == charArray[index + 1])
				{
					count++;
					index++;
				}
				i = index;
				builder.Append($"{charArray[i]}{count}");
			}

			return builder.ToString();
		}
		#endregion

		#region Number to Words
		/// <summary>
        /// Numbers to words.
        /// </summary>
        /// <returns>The to words.</returns>
        /// <param name="number">Number.</param>
        private static string NumberToWords(int number)
        {
            if (number == 0)
                return "Zero";
            string words = "";

            if ((number / 1000000) > 0)
            {
                words += NumberToWords(number / 1000000) + "Million";
                number %= 1000000;
            }

            if ((number / 1000) > 0)
            {
                words += NumberToWords(number / 1000) + "Thousand";
                number %= 1000;
            }

            if ((number / 100) > 0)
            {
                words += NumberToWords(number / 100) + "Hundred";
                number %= 100;
            }

            if (number > 0)
            {

                var unitsMap = new[] { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "seventeen", "Eighteen", "Nineteen" };
                var tensMap = new[] { "Zero", "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

                if (number < 20)
                    words += unitsMap[number];
                else
                {
                    words += tensMap[number / 10];
                    if ((number % 10) > 0)
                        words += unitsMap[number % 10];
                }
            }

            return words;
        }
		#endregion
	}

}

