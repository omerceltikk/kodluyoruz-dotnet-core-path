// See https://aka.ms/new-console-template for more information
uint[] sayiDizisi = new uint[10];

for(int i=0; i<sayiDizisi.Length; i++){
    Console.Write("lütfen {0}. sayyıyı giriniz",i+1);
    sayiDizisi[i] = uint.Parse(Console.ReadLine());
}

Array.Sort(sayiDizisi);
uint[] smallest = new uint[3];
uint[] biggest = new uint[3];
uint smallestAve = 0;
uint biggestAve = 0;
for (int i = 0; i <= 2 ; i++)
{
    smallest[i] = sayiDizisi[i];
    smallestAve += sayiDizisi[i];
}
Array.Reverse(sayiDizisi);
for (int i = 0; i <= 2 ; i++)
{
    biggest[i] = sayiDizisi[i];
    biggestAve += sayiDizisi[i];
}

Console.WriteLine("En büyük ortalama"+(biggestAve/3));
Console.WriteLine("En Küçük ortalama"+(smallestAve/3));
Console.WriteLine("Total ortalama"+((smallestAve+biggestAve)/6));