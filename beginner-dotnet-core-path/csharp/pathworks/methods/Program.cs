// See https://aka.ms/new-console-template for more information

int a =2;
int b= 3;
Console.WriteLine(a+b);

int sonuc = Topla(a,b);

Metotlar ornek = new Metotlar();

ornek.EkranaYazdir(Convert.ToString(sonuc));

int sonuc2 = ornek.ArttirVeTopla(ref a, ref b);
ornek.EkranaYazdir(Convert.ToString(sonuc2));
ornek.EkranaYazdir(Convert.ToString(a+b));

static int Topla(int deger1, int deger2){
    
    return (deger1+ deger2);

}
class Metotlar
{
    public void EkranaYazdir(string veri)
    {
        Console.WriteLine(veri);
    }
    public int ArttirVeTopla(ref int deger1,ref int deger2)
    {
        deger1+=1;
        deger2+=2;
        return deger1+deger2;
    }
    }
    //ref yani referans ile a ve b değerlerinin bellekteki karşılıklarını veriyoruz.

    //************************methods 2-method overloading***************************************//

    //out parametreler 
class program
{
    static void OverLoading(string[] args)
    {
            string sayi = "999";
            bool sonuc = int.TryParse(sayi, out int outSayi);
            //boolean döner
            if( sonuc ){
                Console.WriteLine("başarılı");
                Console.WriteLine(outSayi);
            } else{
                Console.WriteLine("başarısız!");
            }
            Methods instance = new Methods();
            instance.Toplam(4,5,out int toplamSonuc);
            Console.WriteLine(toplamSonuc);

            //method overloading
           int ifade = 999;
           instance.Yazdirmaİslemi(Convert.ToString(ifade)); 
    }
}
class Methods
{
    public void Toplam(int a,int b, out int t){
         t=a+b;
    }
    public void Yazdirmaİslemi(string veri){
        Console.Write(veri);
    }
    public void Yazdirmaİslemi(int veri){
        Console.Write(veri);
    }
    //aynı fonksiyonu 2 farklı kez farklı veri tipiyle overload ettik
}
