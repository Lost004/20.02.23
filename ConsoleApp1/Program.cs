using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
	internal class Program
	{
		private static object arrlist;
		private static object arlist1;

		static void Main(string[] args)
		{
			var arlıst1 = new ArrayList();
			arlist1.Add(1);
			arlist1.Add("Nazim");
			arlist1.Add(" ");
			arrlist.Add(true);
			arrlist.Add(4.5);
			arrlist.Add(null);
			var arlist2 = new ArrayList()
			{
					2, "Steve", " ", true, 4.5, null
			};

			var arlist1 = new ArrayList();

			var arlist2 = new ArrayList()
					{
						1, "Nazim", " ", true, 4.5, null
					};

			int[] arr = { 100, 200, 300, 400 };

			Queue myQ = new Queue();
			myQ.Enqueue("Hello");
			myQ.Enqueue("World!");

			arlist1.AddRange(arlist2); 
			arlist1.AddRange(arr); 
			arlist1.AddRange(myQ);

			var students = new List<Student>()
			{
				new Student(){ Id = 1, Name="Leman"},
				new Student(){ Id = 2, Name="Aga"},
				new Student(){ Id = 3, Name="isa"},
				new Student(){ Id = 4, Name="kamal"}
			};

			string[] cities = new string[3] { "Turkiye", "London", "Azerbaycan" };

			var popularCities = new List<string>();

			
			popularCities.AddRange(cities);

			var favouriteCities = new List<string>();

			
			favouriteCities.AddRange(popularCities);

			List<int> numbers = new List<int>() { 1, 2, 5, 7, 8, 10 };
			Console.WriteLine(numbers[0]); 
			Console.WriteLine(numbers[1]); 
			Console.WriteLine(numbers[2]); 
			Console.WriteLine(numbers[3]); 

			
			numbers.ForEach(num => Console.WriteLine(num + ", "));

			
			for (int i = 0; i < numbers.Count; i++)
				Console.WriteLine(numbers[i]);

			var students = new List<Student>()
			{
				new Student(){ Id = 1, Name="Nazim"},
				new Student(){ Id = 2, Name="Ibrahimov"},
				new Student(){ Id = 3, Name="toto"},
				new Student(){ Id = 4, Name="Abdul"}
			};

		
			var result = from s in students
						 where s.Name == "Bill"
						 select s;

			foreach (var student in result)
				Console.WriteLine(student.Id + ", " + student.Name);


			SortedList<int, string> numberNames = new SortedList<int, string>();
			numberNames.Add(3, "3");
			numberNames.Add(1, "1");
			numberNames.Add(2, “2");
			numberNames.Add(4, null);
			numberNames.Add(10, "10");
			numberNames.Add(5, “5");
			

			SortedList<int, string> numberNames = new SortedList<int, string>()
												{
										{3, "Three"},
										{5, "Five"},
										{1, "One"}
												};

			Console.WriteLine("---Initial key-values--");

			foreach (KeyValuePair<int, string> kvp in numberNames)
				Console.WriteLine("key: {0}, value: {1}", kvp.Key, kvp.Value);

			numberNames.Add(6, "Six");
			numberNames.Add(2, "Two");
			numberNames.Add(4, "Four");

			Console.WriteLine("---After adding new key-values--");

			foreach (var kvp in numberNames)
				Console.WriteLine("key: {0}, value: {1}", kvp.Key, kvp.Value);

			SortedList<int, string> numberNames = new SortedList<int, string>()
									{
										{3, "Three"},
										{1, "One"},
										{2, "Two"}
									};

			Console.WriteLine(numberNames[1]); 
			Console.WriteLine(numberNames[2]); 
			Console.WriteLine(numberNames[3]); 
											  
			numberNames[2] = "TWO"; 
			numberNames[4] = "Four";

			SortedList<int, string> numberNames = new SortedList<int, string>()
									{
										{3, "Three"},
										{1, "One"},
										{2, "Two"}
									};
			if (numberNames.ContainsKey(4))
			{
				numberNames[4] = "four";
			}

			int result;
			if (numberNames.TryGetValue(4, out result))
				Console.WriteLine("Key: {0}, Value: {1}", 4, result);

			SortedList<int, string> numberNames = new SortedList<int, string>()
									{
										{3, "Three"},
										{1, "One"},
										{2, "Two"}
									};
			for (int i = 0; i < numberNames.Count; i++)
			{
				Console.WriteLine("key: {0}, value: {1}", numberNames.Keys[i], numberNames.Values[i]);
			}

			IDictionary<int, string> numberNames = new Dictionary<int, string>();
			numberNames.Add(1, "One"); 
			numberNames.Add(2, "Two");
			numberNames.Add(3, "Three");

		

			foreach (KeyValuePair<int, string> kvp in numberNames)
				Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);

		
			var cities = new Dictionary<string, string>(){
	{"UK", "London, Manchester, Birmingham"},
	{"USA", "Chicago, New York, Washington"},
	{"India", "Mumbai, New Delhi, Pune"}
};

			foreach (var kvp in cities)
				Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);

			var cities = new Dictionary<string, string>(){
	{"UK", "London, Manchester, Birmingham"},
	{"USA", "Chicago, New York, Washington"},
	{"India", "Mumbai, New Delhi, Pune"}
};

			Console.WriteLine(cities["UK"]); 
			Console.WriteLine(cities["USA"]);

			
			if (cities.ContainsKey("France"))
			{
				Console.WriteLine(cities["France"]);
			}

			
			string result;

			if (cities.TryGetValue("France", out result))
			{
				Console.WriteLine(result);
			}

			
			for (int i = 0; i < cities.Count; i++)
			{
				Console.WriteLine("Key: {0}, Value: {1}",
														cities.ElementAt(i).Key,
														cities.ElementAt(i).Value);

				var cities = new Dictionary<string, string>(){
	{"UK", "London, Manchester, Birmingham"},
	{"USA", "Chicago, New York, Washington"},
	{"India", "Mumbai, New Delhi, Pune"}
};

				cities["UK"] = "Liverpool, Bristol"; 
				cities["USA"] = "Los Angeles, Boston"; 

				if (cities.ContainsKey("France"))
				{
					cities["France"] = "Paris";
				}

				var cities = new Dictionary<string, string>(){
             	{"UK", "London, Manchester, Birmingham"},
              	{"USA", "Chicago, New York, Washington"},
	            {"India", "Mumbai, New Delhi, Pune"}
                 };

				cities.Remove("UK"); 

				if (cities.ContainsKey("France"))
				{
					cities.Remove("France");
				}

				cities.Clear();

				Stack<int> myStack = new Stack<int>();
				myStack.Push(1);
				myStack.Push(2);
				myStack.Push(3);
				myStack.Push(4);

				foreach (var item in myStack)
					Console.Write(item + ",");

				Stack<int> myStack = new Stack<int>();
				myStack.Push(1);
				myStack.Push(2);
				myStack.Push(3);
				myStack.Push(4);

				Console.Write("Number of elements in Stack: {0}", myStack.Count);

				if (myStack.Count > 0)
				{
					Console.WriteLine(myStack.Peek());
					Console.WriteLine(myStack.Peek()); 
				}

				Console.Write("Number of elements in Stack: {0}", myStack.Count);

				Stack<int> myStack = new Stack<int>();
				myStack.Push(1);
				myStack.Push(2);
				myStack.Push(3);
				myStack.Push(4);

				myStack.Contains(2);
				myStack.Contains(10);

				Stack<int> myStack = new Stack<int>();
				myStack.Push(1);
				myStack.Push(2);
				myStack.Push(3);
				myStack.Push(4);

				foreach (var item in myStack)
					Console.Write(item + ",");

				Stack<int> myStack = new Stack<int>();
				myStack.Push(1);
				myStack.Push(2);
				myStack.Push(3);
				myStack.Push(4);

				Console.Write("Number of elements in Stack: {0}", myStack.Count);

				if (myStack.Count > 0)
				{
					Console.WriteLine(myStack.Peek()); 
					Console.WriteLine(myStack.Peek()); 
				}

				Console.Write("Number of elements in Stack: {0}", myStack.Count);

				Stack<int> myStack = new Stack<int>();
				myStack.Push(1);
				myStack.Push(2);
				myStack.Push(3);
				myStack.Push(4);

				myStack.Contains(2);
				myStack.Contains(10);






			}
		}
}
