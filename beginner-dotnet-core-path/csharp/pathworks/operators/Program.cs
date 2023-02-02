// See https://aka.ms/new-console-template for more information

//atama ve işlemli atama

bool isSuccess = true;
bool isCompleted = false;

//mantıksal operatörler
if(isSuccess && isCompleted){
    Console.WriteLine("perfect");
}
if(isSuccess || isCompleted){
    Console.WriteLine("great");
}
if(isSuccess || !isCompleted){
    Console.WriteLine("Fine");
}
//ilişkisel operatörler
 
 int a = 3;
 int b = 4;
 bool sonuc = a < b;
 Console.WriteLine(sonuc);
 sonuc = a > b;
 Console.WriteLine(sonuc);
 sonuc = a >= b;
 sonuc = a <= b;
 sonuc = a == b;
 sonuc = a != b;

 //aritmetrik operatörler
 
 int sayi = 10;
 int sayi2 = 5;
 int sonuc1 = sayi/sayi2;
 int sonuc2 = sayi*sayi2;
 int sonuc3 = sayi+sayi2;
 int sonuc4 = sayi-sayi2;

 // % mod alır
 int sonuc5 = 20%3;
  
 