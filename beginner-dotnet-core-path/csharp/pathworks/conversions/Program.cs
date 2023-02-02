// See https://aka.ms/new-console-template for more information
//implicit conversion 

byte a =5;
sbyte b = 30;
short c= 10;

int d = a+b+c;

long h = d;
float i = h;

string e = "sadasd";
char f = 'k';
object g = e+f+d;
//object döner 
//Explicit Conversion 

int x = 4;
byte y = (byte)x;
// veri tipini parantez içerisine belirterek dönüşümü sağladı 

int z = 100;
byte t = (byte)z;

float w= 10.3f;
byte v = (byte)w;
//reel sayıyı yuvarladı

//ToString 
int xx = 6;
string yy = xx.ToString();

string zz = 12.5f.ToString();
//12.5 çıktısı verir

//System.Convert 

string s1 ="10", s2 ="20";
int sayi1, sayi2;
int Toplam;

sayi1 = Convert.ToInt32(s1);
sayi2 = Convert.ToInt32(s2);
Toplam = sayi1 + sayi2;

//Parse
static void ParseMethod()
{
    string metin1 = "10";
    string metin2 = "10.25";
    int rakam1;
    double double1;

    rakam1 = Int32.Parse(metin1);
    double1 = Double.Parse(metin2);
}
ParseMethod();