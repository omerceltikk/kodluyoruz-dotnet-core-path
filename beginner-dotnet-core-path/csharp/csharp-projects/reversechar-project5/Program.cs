// See https://aka.ms/new-console-template for more information
Console.Write("Lütfen bir cümle giriniz.");
string sentence = Console.ReadLine();

char[] arr = sentence.ToCharArray();
Array.Reverse(arr);
string result = string.Join("",arr);
Console.WriteLine(arr);