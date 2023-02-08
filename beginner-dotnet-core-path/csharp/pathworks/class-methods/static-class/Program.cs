// See https://aka.ms/new-console-template for more information


Console.WriteLine("ÇAlışan Sayısı:{0}", Calisan.CalisanSayisi);

Calisan calisan = new Calisan("Ayşe","Kara","ik");
Console.WriteLine("ÇAlışan Sayısı:{0}", Calisan.CalisanSayisi);
Calisan calisan1 = new Calisan("dnz","asd","ik");
Calisan calisan2 = new Calisan("uytr","das","ik");
Islemler.Topla(100,200);
Islemler.Cıkar(100,200);
class Calisan
{
    private static int calisanSayisi;

    public static int CalisanSayisi { get => calisanSayisi; }

    private string Isim;
    private string Soiyisim;
    private string Departman;
    static Calisan(){
        calisanSayisi = 0;

    }
   
    public Calisan(string isim, string soyisim, string departman)
    {
        this.Isim = isim;
        this.Soiyisim = soyisim;
        this.Departman = departman;
        calisanSayisi ++;
    }
    
}
static class Islemler{

    public static long Topla(int sayi1, int sayi2){
        return sayi1+sayi2;
    }
    public static long Cıkar(int sayi1, int sayi2){
        return sayi1-sayi2;
    }

    
}