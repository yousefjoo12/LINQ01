using System.Collections;
using static LINQ01.ListGenerator;
namespace LINQ01
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region LINQ - Restriction Operators
			#region 1
			//var Ruselt = from N in ProductsList
			//			 where N.UnitsInStock == 0
			//			 select N;

			//foreach (var N in Ruselt)
			//{
			//	Console.WriteLine(N);
			//}
			#endregion
			#region 2
			//var Ruselt = from N in ProductsList
			//			 where N.UnitsInStock > 0
			//			 && N.UnitPrice > 3.00M
			//			 select N;

			//foreach (var N in Ruselt)
			//{
			//	Console.WriteLine(N);
			//}
			#endregion
			#region 3
			//List<string> arr = new List<string> { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
			//List<string> NewArr = new List<string>();

			//for (int i = 0; i < arr.Count; i++)
			//{
			//	if (arr[i].Length < i)

			//Console.WriteLine(arr[i]);

			//}

			//another answer

			//List<string> arr2 = new List<string> { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
			//var NewArr2 = arr2.Where((N, I) => N.Length < I++);

			//foreach (var m in NewArr2)
			//{
			//	Console.WriteLine(m);
			//}

			#endregion
			#endregion

			#region LINQ - Ordering Operators
			#region 1
			//var Ruselt = from N in ProductsList
			//			 orderby N.ProductName
			//			 select N;

			//foreach (var N in Ruselt)
			//{
			//	Console.WriteLine(N);
			//}
			#endregion
			#region 2
			//string[] Arr = { "aPPLE", "BlUeBeRrY", "AbAcUs", "bRaNcH", "ClOvEr", "cHeRry" };

			//Array.Sort(Arr);
			//foreach (string str in Arr) {
			//             Console.WriteLine(str);
			//         }
			#endregion
			#region 3
			//var Ruselt = from N in ProductsList
			//			 orderby  N.UnitsInStock  descending
			//			 select N;

			//foreach (var N in Ruselt)
			//{
			//	Console.WriteLine(N);
			//}
			#endregion
			#region 4
			//List<string> arr2 = new List<string> { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };

			//var SorArr = arr2.OrderBy(x => x.Length).ThenBy(x => x);

			//foreach (var m in SorArr)
			//{
			//	Console.WriteLine(m);
			//}
			#endregion
			#region 5
			//string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };


			//var Result = words
			//    .OrderBy(word => word.Length)
			//    .ThenBy(word => word, StringComparer.OrdinalIgnoreCase);
			//foreach (var word in Result)
			//{
			//    Console.WriteLine(word);
			//}

			#endregion
			#region 6
			// var Result09 = ListGenerator.ProductList.OrderByDescending(p => p.Category).ThenByDescending(p => p.UnitPrice);
			//Result09=from p in ListGenerator.ProductList
			//         orderby p.Category,p.UnitPrice descending
			//         select p;
			// foreach (var item in Result09)
			// {
			//     Console.WriteLine(item);
			// }

			#endregion
			#region 7
			string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

			var Result = Arr
				.OrderBy(word => word.Length)
				.ThenByDescending(word => word, StringComparer.OrdinalIgnoreCase);

			foreach (var item in Result)
			{
				Console.WriteLine(item);
			}
			#endregion
			#region 8
			//string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

			//var Result11 = Arr
			//    .Where(word => word.Length > 1 && word[1] == 'i')
			//    .Reverse();
			//foreach (var item in Result11)
			//{
			//    Console.WriteLine(item);
			//}
			#endregion
			#endregion
		}
	}
}
