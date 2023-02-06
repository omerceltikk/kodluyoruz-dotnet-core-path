// See https://aka.ms/new-console-template for more information

string degisken = "dersimiz CSharp hoşgeldiniz!";
string degisken2 = "CSharp";

//length 
Console.WriteLine(degisken.Length);

//ToUpper ToLower
Console.WriteLine(degisken.ToUpper());
Console.WriteLine(degisken.ToLower());

//Concat -birleştirme işlemi
Console.WriteLine(String.Concat(degisken,"degisken"));

//Compare, CompareTo 1,0,-1 döner değişken karakter sayısı ile
Console.WriteLine(degisken.CompareTo(degisken2));
Console.WriteLine(String.Compare(degisken,degisken2,true));
Console.WriteLine(String.Compare(degisken,degisken2,false));
//true büyük küçük harf duyarsız falseda ise duyarlı

//Contains 
Console.WriteLine(degisken.Contains(degisken2));
Console.WriteLine(degisken.EndsWith("hoşgeldiniz!"));
Console.WriteLine(degisken.StartsWith("Merhaba"));

//IndexOf
Console.WriteLine(degisken.IndexOf("CSharp"));
Console.WriteLine(degisken.LastIndexOf("i"));

//Insert-ekleme
Console.WriteLine(degisken.Insert(0,"Merhaba!"));

//PadLeft PadRight 
Console.WriteLine(degisken + degisken2.PadLeft(30));
//degisken 2 nin sonuna 30 a tamamlaacak kadar boşluk ekler veya istenilen karakteri right ta sağına ekler 

//Remove
Console.WriteLine(degisken.Remove(10));

//Replace
Console.WriteLine(degisken.Replace("CSharp", "C#"));
Console.WriteLine(degisken.Replace(" ", "*"));

//Split
Console.WriteLine(degisken.Split(" "[1]));

//SubString 'den başlayarak sonuna kadar getir
Console.WriteLine(degisken.Substring(4));
Console.WriteLine(degisken.Substring(4));

