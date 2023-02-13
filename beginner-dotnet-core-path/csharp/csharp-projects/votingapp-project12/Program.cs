using VOTE.Data;
using VOTE.Progress;
// See https://aka.ms/new-console-template for more information
double percent ;
Console.WriteLine("Voting App'e Hoşgeldiniz");

Database datas = new();

addUser useradd = new();
useradd.Add();
mainMenu:

ListData data = new();
data.List();

Console.WriteLine("Oylamaya devam etmek için (1)/ Sonuçları görmek için (2)");
int sonuc = int.Parse(Console.ReadLine());
if(sonuc == 1){
    goto mainMenu;
    
}else if (sonuc == 2){
    
}
