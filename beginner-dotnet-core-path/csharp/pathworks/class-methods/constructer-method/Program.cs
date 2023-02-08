// See https://aka.ms/new-console-template for more information
using System;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Calisan calisan1 = new Calisan();
        calisan1.ad = "Ayşe";
        calisan1.soyad = "Kara";
        calisan1.No = 1232332132;
        calisan1.Departman = "İnsan Kaynakları";

        calisan1.CalisanBilgileri();

        Calisan calisan2 = new Calisan();
        calisan2.ad = "Deniz";
        calisan2.soyad = "Arda";
        calisan2.No = 1232332232;
        calisan2.Departman = "Satın Alma";
        
        calisan2.CalisanBilgileri();
    }
}
// [Erişim Belirleyici][Veri Tipi] ÖzellikAdı;
//  [Erişim Belirleyici][Geri Dönüş Değerinin Tipi] MetotAdi([Parametreler])
 class Calisan{

    public string ad;
    public string soyad;
    public int No;
    public string Departman;
    public void CalisanBilgileri(){
        Console.WriteLine("Çalışan Adı{0}",ad);
        Console.WriteLine("Çalışan Soydı{0}",soyad);
        Console.WriteLine("Çalışan No{0}",No);
        Console.WriteLine("Çalışan Departman{0}",Departman);
    }

 }
 