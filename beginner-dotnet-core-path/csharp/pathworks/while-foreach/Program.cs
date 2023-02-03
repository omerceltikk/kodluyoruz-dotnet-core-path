// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


int sayi = int.Parse(Console.ReadLine());
int sayac = 1;
int toplam = 0;

while(sayac <= sayi){

    toplam += sayac;
    sayac++;
}
Console.WriteLine(toplam/sayi);

int character = 'a';
while (character < 'z')
{
    Console.Write(character);
    character ++;
}
string[] arabalar = {"Ford","Toyota","Nissan","BMW"};
foreach (var item in arabalar)
{
    Console.WriteLine(item);
}