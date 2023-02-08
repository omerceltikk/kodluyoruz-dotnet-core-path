// See https://aka.ms/new-console-template for more information
using System;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Calisan calisan1 = new Calisan("Ayşe","Kara",12312321,"İnsan Kaynakları");
        calisan1.CalisanBilgileri();


        Calisan calisan2 = new Calisan();
        calisan2.ad = "Deniz";
        calisan2.soyad = "Arda";
        calisan2.No = 1232332232;
        calisan2.Departman = "Satın Alma";
        
        calisan2.CalisanBilgileri();

        Calisan calisan3 = new Calisan("asdasd","asdsada");
        calisan3.CalisanBilgileri();
        //girilmeyen bilgileri default null ve 0 döndürür
    }
}
// [Erişim Belirleyici][Veri Tipi] ÖzellikAdı;
//  [Erişim Belirleyici][Geri Dönüş Değerinin Tipi] MetotAdi([Parametreler])
 class Calisan{

    public string ad;
    public string soyad;
    public int No;
    public string Departman;

    public Calisan(string ad, string soyad, int No, string Departman)
    {
       this.ad = ad;
       this.soyad = soyad;
       this.No = No;
       this.Departman = Departman;
    
    }
    public Calisan(string ad, string soyad)
    {
       this.ad = ad;
       this.soyad = soyad;
    }
    public Calisan(){}
    public void CalisanBilgileri(){
        Console.WriteLine("Çalışan Adı{0}",ad);
        Console.WriteLine("Çalışan Soydı{0}",soyad);
        Console.WriteLine("Çalışan No{0}",No);
        Console.WriteLine("Çalışan Departman{0}",Departman);
    }

 }
 