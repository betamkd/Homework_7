//Write a program that checks if a word is a palindrome.

using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography.X509Certificates;

Console.WriteLine("Enter a word to check if it is a palindrome:");

string input = Console.ReadLine();

string reversedInput = new string(input.Reverse().ToArray());

if (input == reversedInput)
{
	Console.WriteLine("The entered text is a palindrome.", input);
}
else 
{
	Console.WriteLine("The entered text is not a palindrome.", input);
}

Console.WriteLine("**************************");
Console.WriteLine("\n");
//Write a C# program to find the longest common prefix of an array of strings using the ".Substring()" method.

Console.WriteLine("Find the longest common prefix in the array.");
string[] strings = { "apple", "application", "aptitude", "apricot" };
string prefix = FindLongestCommonPrefix(strings);
Console.WriteLine(prefix);

string FindLongestCommonPrefix(string[] strings)
{
	if (strings == null || strings.Length == 0)
		return string.Empty;

	string prefix = strings[0];

	foreach (string s in strings)
	{
		while (!s.StartsWith(prefix))
		{
			prefix = prefix.Substring(0, prefix.Length - 1);

			if (prefix == string.Empty)
				return string.Empty;
		}
	}
	return prefix;
}

Console.WriteLine("**************************");
Console.WriteLine("\n");
// Write a C# program to convert a string to a camel case format 

string inputString = "the quick brown fox";

string[] words = inputString.Split(' ');
string camelCaseString = words[0].ToLower();

for (int i = 1; i < words.Length; i++)
{
	string firstLetter = words[i].Substring(0, 1);
	string remainingLetters = words[i].Substring(1);
	camelCaseString += firstLetter.ToUpper() + remainingLetters.ToLower();
}

Console.WriteLine(camelCaseString);
Console.WriteLine("**************************");
Console.WriteLine("\n");






