// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//encapsulation ile diğer nesnelerden class alrdan koruma işlemi yapmak
Ogrenci ogrenci = new Ogrenci();
ogrenci.Isim = "Ayşe";
ogrenci.Soyisim="Yılmaz";
ogrenci.OgrenciNo=293;
ogrenci.Sinif=4;
ogrenci.OgrenciBilgileriniGetir();

ogrenci.SinifAtlat();
ogrenci.OgrenciBilgileriniGetir();
class Ogrenci
{
    private string? isim;
    private string soyisim;
    private int ogrenciNo;
    private int sinif;

    //private olarak tanımladık
    public string? Isim { get => isim; set => isim = value; }
    public string Soyisim { get => soyisim; set => soyisim = value; }
    public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
    public int Sinif { 
        get => sinif; 
        set{
            if(value < 1){
                Console.WriteLine("Sınıf en az 1 olabilir");
                sinif =1;
            }else
            sinif = value;
            }}
   //sinif verisinde if bloğunu başka bir metot ile 1 in altına indirebilme ihtimalimiz nedeniyle if bloğunu set içerisinde kullandık 
   //get ile ismi return edip setliyoruz böylece kapsüle etmil oluyoruz

   public Ogrenci(){}
   public Ogrenci(string Isim, string Soyisim, int OgrenciNo, int Sinif){
    Isim = isim;
    Soyisim = soyisim;
    ogrenciNo = ogrenciNo;
    Sinif = sinif;
   }
   public void OgrenciBilgileriniGetir()
   {
    Console.WriteLine("Öğrenci Adı     :{0}",this.Isim);
    Console.WriteLine("Öğrenci Soyadı     :{0}",this.Soyisim);
    Console.WriteLine("Öğrenci No     :{0}",this.OgrenciNo);
    Console.WriteLine("Öğrenci Sınıf     :{0}",this.Sinif);
   }
   public void SinifAtlat()
   {
    this.Sinif = this.Sinif +1;
   }
   public void SinifDusur()
   {
    this.Sinif = this.Sinif -1;
   }
   }
