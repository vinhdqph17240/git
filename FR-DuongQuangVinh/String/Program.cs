using System;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            //KhoiTao();
			//CompareIgnoreCase();
			StringSearch();

		}
        static void KhoiTao()
        {
            string a = new string('a', 10);

        }

		public static string ConstructorString()
		{
			return new string('a', 10);
		}
		public static void StringFormat()
		{
			string str = "Format ví dụ";
			Console.WriteLine(str);
		}
		public static void CompareIgnoreCase()
		{
			string var1 = "String";
			string var2 = "string";
			if (var1.Equals(var2))
			{
				Console.WriteLine("các chuỗi bằng nhau");
			}
			else
			{
				Console.WriteLine("các chuỗi không bằng nhau");
			}
		}
		public static void StringSearch()
		{
			string str = "String";
			Console.WriteLine("Example Indexof " + str.IndexOf('S'));
			Console.WriteLine("Example StartWith " + str.StartsWith("S"));
			Console.WriteLine("Example StartWith " + str.EndsWith("S"));

		}
		public static void Concat_Split_join()
		{
			string str = "Hello mọi người";
			string str1 = " Chào Bạn";
			string[] arrString = { "example", "Join" };
			string name = "   Dương Quang Vinh  ";
			Console.WriteLine("Example Concat " + string.Concat(str, str1));
			Console.WriteLine(string.Join("-", arrString));
			Console.WriteLine("Example Trim " + name.Trim());
			Console.WriteLine("Viết Hoa " + name.ToUpper());
			Console.WriteLine("Viết Thường " + name.ToLower());

		}
	}
}

