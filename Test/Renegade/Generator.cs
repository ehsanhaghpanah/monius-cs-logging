/**
 * Copyright (C) moniüs, 2016.
 * All rights reserved.
 * E. Haghpanah; haghpanah@monius.net
 */

using System;
using System.IO;
using System.Text;

namespace Renegade
{
	public sealed class Generator
	{
		public static readonly Random Random = new Random((int)DateTime.Now.Ticks);

		public static string get_mobile_number(string prefix = "0917")
		{
			return prefix + Random.Next(1000000, 9999999);
		}

		public static string get_mobile_number(long l, string prefix = "09")
		{
			const string zeros = "00000000000";
			var format = zeros.Substring(0, zeros.Length - prefix.Length);
			return prefix + l.ToString(format);
		}

		public static string get_string(int size)
		{
			var sb = new StringBuilder();
			for (var i = 0; i < size; i++)
				sb.Append((char)Random.Next('a', 'z' + 1));
			return sb.ToString();
		}

		public static string get_email_address()
		{
			return get_string(16) + "@" + get_string(8) + "." + get_string(3);
		}

		public static string get_lowercase(int size)
		{
			var sb = new StringBuilder();
			for (var i = 0; i < size; i++)
				sb.Append((char)Random.Next('a', 'z' + 1));
			return sb.ToString();
		}

		public static string get_uppercase(int size)
		{
			return get_lowercase(size).ToUpper();
		}

		public static string get_digits(int size)
		{
			var sb = new StringBuilder();
			for (var i = 0; i < size; i++)
				sb.Append((char)Random.Next('0', '9' + 1));
			return sb.ToString();
		}

		public static string get_specials(int size)
		{
			return "~!@#$%^&*()_+".Substring(size <= 13 ? size : 13);
		}

		public static string get_strong_password()
		{
			return get_lowercase(3) + get_uppercase(3) + get_digits(3) + get_specials(3);
		}

		public static string get_ip()
		{
			return Random.Next(100, 255) + "." + Random.Next(100, 255) + "." + Random.Next(100, 255) + "." + Random.Next(100, 255);
		}

		public static string get_os()
		{
			var list = new[] { "Web", "iOS", "Android", "Windows" };
			return list[Random.Next(0, 3)];
		}

		public static string get_new_national_id()
		{
			var s = Random.Next(123456789, 987654321).ToString();
			int sum = 0, check_digit;
			for (var i = 0; i < 9; i++)
				sum += (int.Parse(s.Substring(i, 1)) * (10 - i));
			var mod = sum % 11;
			if (mod < 2)
				check_digit = mod;
			else
				check_digit = (11 - mod);

			return s + check_digit;
		}

		public static string get_persian_name_frst()
		{
			var reader = new StreamReader("name_frst.txt");
			var result = reader.ReadToEnd();
			var list = result.Split(new[] { '\n' });
			var indx = Random.Next(0, list.Length);
			return list[indx];
		}

		public static string get_persian_name_last()
		{
			var reader = new StreamReader("name_last.txt");
			var result = reader.ReadToEnd();
			var list = result.Split(new[] { '\n' });
			var indx = Random.Next(0, list.Length);
			return list[indx];
		}

		public static string get_value(string path)
		{
			var reader = new StreamReader(path);
			var result = reader.ReadToEnd();
			var list = result.Split(new[] { '\n' });
			var indx = Random.Next(0, list.Length);
			return list[indx];
		}

		public static TimeSpan get_timeSpan()
		{
			return new TimeSpan(0, 0, 0, 0, Random.Next(100, 250));
		}
	}
}