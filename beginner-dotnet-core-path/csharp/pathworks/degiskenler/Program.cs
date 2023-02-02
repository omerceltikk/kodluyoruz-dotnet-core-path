// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

byte b =5;
sbyte c =5;

short s= 5;
ushort us =5;

Int16 i16 = 2;
int i= 2;
Int32 i32 = 2;
Int64 i64 = 4;

uint ui = 2;
long l =4 ;
ulong ul = 4;

//reel sayılar
float f =5;
double d = 2;
decimal dec = 45;

char ch = '2';
string str = "aaaaa";

bool x = true;

DateTime dt = DateTime.Now;

object o1 = "x";
object o2 = 'y';
object o3 = 4.67;

string str1  = string.Empty;
str1 = "aaaaaa";
string ad = "ahmet";
string soyad = "mehmet";
string tamisim = ad + soyad;

//int tanımlama şekilleri 
int integer1 = 5;
int integer2 = 5;
int integer3 = integer1 * integer2;


 //değişken dönüşümleri 

 string str20 = "20";
 int int20 = 20;
 
 string yenideger = str20 + int20.ToString();
 Console.WriteLine(yenideger);
 
 int yeniint = int20 + Convert.ToInt32(str20);
 Console.WriteLine(yenideger);
 
 int int22 = int20 + int.Parse(str20);

//datetime

string datetime = DateTime.Now.ToString("dd.MM.yyyy");
Console.WriteLine(datetime);

string hour = DateTime.Now.ToString("HH:mm");
