// See https://aka.ms/new-console-template for more information


Console.WriteLine(Gunler.Pazar);
Console.WriteLine((int)Gunler.Cumartesi);
int sicaklik = 32;
if(sicaklik <= (int)HavaSicakligi.normal){
    Console.WriteLine("Dışarıya çıkmak için havanın biraz daha sınımasını bekleyin");
}else if( sicaklik >= (int)HavaSicakligi.sıcak){
    Console.WriteLine("Dışarıya çıkmak için çok sıcak bir gün");
}else if(sicaklik >= (int)HavaSicakligi.normal && sicaklik<(int)HavaSicakligi.coksıcak){
    Console.WriteLine("haydi dışarı çıkalım");

}
enum Gunler{
    Pazartesi=1,
    Salı,
    Çarşamba,
    Perşembe,
    Cuma,
    Cumartesi,
    Pazar
}

enum HavaSicakligi{
    soguk = 5,
    normal = 20,
    sıcak = 25,
    
    coksıcak=30
}