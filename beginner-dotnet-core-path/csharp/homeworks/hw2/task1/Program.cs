// See https://aka.ms/new-console-template for more information
using System.Collections;
uint[] dizi = new uint[20];
ArrayList asal = new ArrayList();
ArrayList asalOlmayan = new ArrayList();
int sayac = 0;

for(int i=0; i<dizi.Length; i++){
    Console.Write("lütfen {0}. sayyıyı giriniz",i+1);
    dizi[i] = uint.Parse(Console.ReadLine());
}
for (int i = 0; i < dizi.Length; i++)
{
    for(int j = 1; j <= dizi[i]; j++)
    {
        if(dizi[i] %  j == 0){
            sayac++;
        }
        if(sayac==2){
            asal.Add(dizi[i]);
        }else if(sayac >= 3){
            asalOlmayan.Add(dizi[i]);
            break;
        }
    }
}
asal.Sort();
asalOlmayan.Sort();
asal.Reverse();
asalOlmayan.Reverse();
foreach (var item in asal)
{
    Console.WriteLine(item);
}
foreach (var item in asalOlmayan)
{
    Console.WriteLine(item);
}

Console.WriteLine(asal.Count);
Console.WriteLine(asalOlmayan.Count);
