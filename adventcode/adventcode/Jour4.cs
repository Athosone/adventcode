using System;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;


namespace adventcode
{

	//#MultiThread
	public class Jour4
	{
		//private static volatile Object locker = new Object ();
		private static volatile MD5 md5 = System.Security.Cryptography.MD5.Create ();

		public static string input = "yzbqklnj";

		public Jour4 ()
		{
		}


		public static string CreateMD5 (string input)
		{
			byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes (input);
			byte[] hashBytes = null;

			//lock (locker) {
				hashBytes = md5.ComputeHash (inputBytes);
			//}

			StringBuilder sb = new StringBuilder ();
			for (int i = 0; i < hashBytes.Length; i++) {
				sb.Append (hashBytes [i].ToString ("X2"));
			}
			return sb.ToString ();
		}
			
		public static int GetResult (int range, string match)
		{
			int position = 0;
			string testString = "         ";

			while (testString.Substring (0, range) != match) {
				testString = CreateMD5 (input + position);
				position = position + 1;
			}
			return position - 1;
		}
	}
}

