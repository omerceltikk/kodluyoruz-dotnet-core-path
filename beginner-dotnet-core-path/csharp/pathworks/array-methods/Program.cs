// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string[] renkler = new string[5];
string[] hayvanlar = {"kedi","köpek","kuş","maymun"};
int[] dizi;
dizi = new int[5];

renkler[0] = "mavi";
Console.WriteLine(hayvanlar[0]);
dizi[3] = 10;

Console.WriteLine(dizi[3]);
Console.WriteLine(hayvanlar[1]);
Console.WriteLine(renkler[0]);

int diziUzunlugu =int.Parse(Console.ReadLine());
int[] sayilar = new int[diziUzunlugu]; 

for(int i=0; i< diziUzunlugu; i++)
{
    Console.Write("lütfen {0}. sayısı giriniz", i+1);
    sayilar[i] = int.Parse(Console.ReadLine());
}
int toplam = 0;
foreach (var item in sayilar)
{
    toplam += item;

}
Console.WriteLine("ortalama:" + toplam/diziUzunlugu);