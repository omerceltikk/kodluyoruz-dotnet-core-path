// See https://aka.ms/new-console-template for more information
Console.WriteLine("Lütfen bir cümle giriniz");
string[] arr = Console.ReadLine().Split(" ");
foreach (var item in arr)
{
    char first = item[0];
    char last = item[item.Length-1];
    string sentence = last + item.Substring(1, item.Length-2) + first;
    Console.Write(sentence+ " ");
}