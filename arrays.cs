using System;

public class Program
{
	public static void Main()
	{
		int[] array = new int[] { 1, 2, 3 };
		array.PrintElements();
		array[1] = 10;
		array.PrintElements();

		try
		{
			array[3] = 10;
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
		}

		//A Multi-Dimensional Array, 2D
		int[,] a = {
			{1, 2, 3},
			{4, 5, 6}
		};
		Console.WriteLine($"A multi-dimensional array length: {a.Length}");

		//A jagged array. It's an array of arrays, so you need to
		//initialize nested arrays afterwards
		int[][] b = {
			new int[] {1,2,3},
			new int[] {10,20,30,40,50},
			new int[] {5,6},
		};
		Console.WriteLine($"The jagged array length: {b.Length}");
		Console.WriteLine($"The nested array length: {b[1].Length}");

		//An element in the first row, first column
		a[0, 0] = 10;

		//The first element's first element
		b[0][0] = 10;

		//int[2][2][2] or int[2][2][] is not possible
		//You can initialize only the first rank
		//Nested arrays are not initialized
		//c[0].Length will give null reference exception
		int[][][] c = new int[2][][];
	}
	//Creating Arrays
	public static void MakeArray()
	{
		//Multi-dimensional arrays have more than one index
		int[] x = new int[10];
		int a = x[4];
		int[,] y = new int[2, 3]; //create 2 by 3 array
		int b = y[0, 2]; //Get a value from the index [0,2]
		int len = y.Length;
	}
	//Jagged Array
	public static void MakeJaggedArray()
	{
		//Jagged Array
		//An array of arrays
		int[][] jaggedArray = new int[2][]; //2 elements for the 1st array
		jaggedArray[0] = new int[3]; //new array with 3 elements
		int value = jaggedArray[0][2];
		int jLength = jaggedArray[0].Length; //length 3

		//null reference exception b/c there's nothing in there yet
		//jLength = y[1].Length;
	}
}

//Method Extension
public static class ArrayExtension
{
	//Print out the array (Ex of output: {1, 2, 3})
	public static void PrintElements(this int[] array)
	{
        Console.Write("{");
		foreach (var element in array)
		{
			Console.Write("" + element + ", ");
		}
		//Call backspace twice to get rid of the extra comma
		Console.WriteLine("\b\b}");
	}
}