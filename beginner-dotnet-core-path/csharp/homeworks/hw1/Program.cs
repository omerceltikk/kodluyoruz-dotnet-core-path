// See https://aka.ms/new-console-template for more information

Console.Write("TASK 1-lütfen n değişkenini giriniz.");
uint n = uint.Parse(Console.ReadLine());
uint[] dizi = new uint[n];

for(int i = 0; i<n; i++){
    Console.Write("lütfen {0}. sayyıyı giriniz",i+1);
    dizi[i] = uint.Parse(Console.ReadLine());
}
for(int i = 0; i <n ;i++)
  {
    if(dizi[i] % 2 == 0){
        Console.WriteLine(dizi[i]);
    }
  }
Console.Write("TASK 1-Tamamlandı");

Console.Write("TASK 2-Lütfen m değişkenini giriniz.");
    uint m = uint.Parse(Console.ReadLine());
   for (int i = 0; i < n; i++)
   {
    uint kalan = dizi[i] % m; 
     if( dizi[i] == m){
        Console.WriteLine(dizi[i]);
    }else if(kalan == 0){
             Console.WriteLine(dizi[i]);
    }
   }
Console.Write("TASK 2-Tamamlandı");

Console.Write("TASK 3-Lütfen n sayısı kadar kelime giriniz");
string[] kelimeDizi = new string[n];
for(uint i = 0; i < n; i++){
    Console.Write("lütfen {0}. kelimeyi giriniz",i+1);
    kelimeDizi[i] = Convert.ToString(Console.ReadLine());
}
// kelimeDizi.Reverse();
for (int i = kelimeDizi.Length; i >= 0; i--)
{
    Console.WriteLine(kelimeDizi[i]);
}
    Console.Write("TASK 3-Tamamlandı");

    Console.Write("TASK 4-Lütfen bir cümle giriniz");
    string cumle = Convert.ToString(Console.ReadLine());
    string[] words = cumle.Split(' ');
    Console.WriteLine("Words length:" + words.Length);
    string wordsJoined = string.Join("",words);
    char[] charac = wordsJoined.ToCharArray();
    Console.WriteLine("Character length:" + charac.Length);
   
