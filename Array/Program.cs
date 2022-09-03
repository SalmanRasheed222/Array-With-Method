using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

int[] items=new int[6];

for(int i=0;i<items.Length;i++)
{
	Console.Write("Enter the Price of Item "+(i+1)+": ");
	items[i] = Convert.ToInt32(Console.ReadLine()); 
}

for(int i=0;i<items.Length;i++)
{
	Console.WriteLine((i+1)+" Price:" + items[i]);
	
}


int sum = items.Sum();
int maxValue = items.Max();
int maxIndex = items.ToList().IndexOf(maxValue);
Console.WriteLine("max Price is: " + maxValue);
Console.WriteLine("Index of Max Price is: " + (maxIndex+1));
Console.WriteLine("Total:" + sum);

Array.Reverse(items);
Console.WriteLine(String.Join(Environment.NewLine, items));
