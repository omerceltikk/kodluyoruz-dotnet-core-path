// See https://aka.ms/new-console-template for more information
string sentence = Convert.ToString(Console.ReadLine());
char[] vowels = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };
 List<char> arr = new List<char>(){ };

foreach (char character in sentence)
{
    foreach(char item in vowels){
        if(character == item){
            arr.Add(character);
        }
    }
}
foreach (char item in arr)
{
    Console.Write(item);
}
